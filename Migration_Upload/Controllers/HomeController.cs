using Azure;
using Azure.Core;
using Context.Capmas_Test;
using Context.Old_Models;
using DTOS.DTO;
using IServices_Repository_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Migration_Upload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IOLDNewsRepo _oldNewsRepo;
        private readonly INew_News_Repo _new_News_Repo;
        private readonly IHistory_Details_Repo _history_Details_Repo;
        private readonly CapmasTestContext _capmasContext;
        private readonly NewCapmasWebsiteContext _oldContext;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        private string wwwrootPath;

        public HomeController(IOLDNewsRepo oldNewsRepo,
                              INew_News_Repo new_News_Repo,
                              IHistory_Details_Repo history_Details_Repo,
                              CapmasTestContext capmasContext,
                              NewCapmasWebsiteContext oldContext,
                              IHostingEnvironment hostingEnvironment,
                              IConfiguration configuration)
        {
            _oldNewsRepo = oldNewsRepo;
            _new_News_Repo = new_News_Repo;
            _history_Details_Repo = history_Details_Repo;
            _capmasContext = capmasContext;
            _oldContext = oldContext;
            _hostingEnvironment = hostingEnvironment;
            _configuration = configuration;
        }
                  
        private async Task DownloadAndSaveNewsPdf(string pdfUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                var pdfBytes = await webClient.DownloadDataTaskAsync(new Uri(pdfUrl));
                var dir = _hostingEnvironment.WebRootPath;
                string relativePath = "recycle_news_ar_pdf";
                string currentDirectory = Directory.GetCurrentDirectory();


                var fullPath = Path.Combine(dir, relativePath);
                var pdfFileName = Path.GetFileName(new Uri(pdfUrl).LocalPath);
                var pdfFilePath = Path.Combine(fullPath, pdfFileName);

                await System.IO.File.WriteAllBytesAsync(pdfFilePath, pdfBytes);
            }
        }
        private async Task DownloadAndSaveMagazinePdf(string pdfUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                if (pdfUrl.Contains("census"))
                {

                }
                else
                {

                    var pdfBytes = await webClient.DownloadDataTaskAsync(new Uri(pdfUrl));
                    var dir = _hostingEnvironment.WebRootPath;
                    string relativePath = "pdf/new_Pdf";
                    string currentDirectory = Directory.GetCurrentDirectory();


                    var fullPath = Path.Combine(dir, relativePath);
                    var pdfFileName = Path.GetFileName(new Uri(pdfUrl).LocalPath);
                    var pdfFilePath = Path.Combine(fullPath, pdfFileName);

                    await System.IO.File.WriteAllBytesAsync(pdfFilePath, pdfBytes);
                }
            }
        }
        private async Task<string?> ReWriteFilePath(string file, string directory)
        {
            using (var httpClient = new HttpClient())
            {
                var origin = _configuration.GetSection("origin").Value;
                var refer = _configuration.GetSection("refer").Value;
                var token = _configuration.GetSection("token").Value;

                httpClient.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
                httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-EG,en;q=0.9,ar-EG;q=0.8,ar;q=0.7,en-GB;q=0.6,en-US;q=0.5");
                httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
                httpClient.DefaultRequestHeaders.Add("Origin", origin);
                httpClient.DefaultRequestHeaders.Add("Referer", refer);
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36");
                httpClient.DefaultRequestHeaders.Add("Authorization", token);

                var content = new MultipartFormDataContent();
                using (var fileStream = System.IO.File.OpenRead(file))
                {
                    content.Add(new StreamContent(fileStream), "files", Path.GetFileName(file));
                    content.Add(new StringContent(directory), "directory");

                    var url = _configuration.GetSection("EndPoint").Value;
                    var response = await httpClient.PostAsync(url, content);
                     if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var responseModel = JsonConvert.DeserializeObject<ResponseModel>(result);
                        if (responseModel is not null)
                        {
                            if (responseModel.FilePath != null && responseModel.FilePath.Length > 0)
                            {
                                var newUrl = responseModel.FilePath[0].Image;
                                return newUrl;
                            }
                            else
                            {
                                return null;
                            }
                        }
                        return null;
                    }
                }

                return null;
            }

        }

        [HttpPost]
        [Route("MergeNewsPdfFiles")]
        public async Task<IActionResult> MergeNewsPdfFiles()
        {
            //1-Get All News Files From (NewCapmasWebsiteContext-tblNewsFiles) [Note We Want to get all .pdf files]
            var oldNewsFiles = await _oldNewsRepo.GetAllNewsFiles();
            var dir = _hostingEnvironment.WebRootPath;
            var newsList = new List<New_News_DTO>();
            var url = _configuration.GetSection("urlPath").Value;

            foreach (var file in oldNewsFiles)
            {
                //2-Get All News Objects From (NewCapmasWebsiteContext-tblNews)
                var targetNew = await _oldContext.TblNews.AsNoTracking().Where(c => c.NewsId == file.News_ID && c.NewsIsPublished == true && c.NewsVisible == true).FirstOrDefaultAsync();
                if (targetNew is not null)
                {

                    #region Re Write AR Path
                    string filePath = $"{dir}{file.NL_LinkAr}";
                    string? arPdfPath = null;

                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        byte[] pdfBytes = System.IO.File.ReadAllBytes(filePath);
                        System.IO.File.WriteAllBytes(filePath, pdfBytes);
                        arPdfPath = await ReWriteFilePath(filePath, "2");
                    }
                    #endregion


                    var news = new News();
                    if (arPdfPath != null)
                    {

                        #region Insert News
                        news.Brief = targetNew.NewsBriefAr;
                        news.IsPdf = true;
                        news.PdfUrl = arPdfPath != null ? arPdfPath : file.NL_LinkAr;
                        news.PublishDate = targetNew.NewsPublishDate;
                        news.Title = targetNew.NewsNameAr;
                        news.IsPublished = true;
                        news.IsDeleted = false;
                        news.Status = 3;

                        await _capmasContext.News.AddAsync(news);
                        await _capmasContext.SaveChangesAsync();
                        #endregion
                    }
                    //Store the failed ar pdf to recycle_news_ar_pdf
                    else
                    {
                        var pdfUrl = $"{url}{file.NL_LinkAr}";
                        var pdfBytes = System.IO.File.ReadAllBytes(filePath);

                        string relativePath = "recycle_news_ar_pdf";
                        string currentDirectory = Directory.GetCurrentDirectory();


                        var fullPath = Path.Combine(dir, relativePath);
                        var pdfFileName = Path.GetFileName(new Uri(pdfUrl).LocalPath);
                        var pdfFilePath = Path.Combine(fullPath, pdfFileName);

                        await System.IO.File.WriteAllBytesAsync(pdfFilePath, pdfBytes);

                    }

                    #region Re Write EN Path          

                    string enfilePath = $"{dir}{file.NL_LinkEn}";
                    string? enPdfPath = null;
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {

                        byte[] enpdfBytes = System.IO.File.ReadAllBytes(enfilePath);
                        System.IO.File.WriteAllBytes(enfilePath, enpdfBytes);
                        enPdfPath = await ReWriteFilePath(enfilePath, "2");
                    }
                    #endregion
                    //Check If News Is Successfully added and the path is converted 
                    if (news.Id != 0 && enPdfPath is not null)
                    {
                        #region Insert Translation 

                        var newsTranslation = new NewsTranslation();
                        newsTranslation.NewsId = news.Id;
                        newsTranslation.Locale = "en";
                        newsTranslation.Title = targetNew.NewsNameEn;
                        newsTranslation.Brief = targetNew.NewsBriefEn;
                        newsTranslation.PdfUrl = enPdfPath;
                        await _capmasContext.NewsTranslations.AddAsync(newsTranslation);
                        await _capmasContext.SaveChangesAsync();
                        #endregion
                    }
                    //Store the failed en pdf to recycle_news_en_pdf
                    else
                    {
                        var pdfUrl = $"{url}{file.NL_LinkEn}";


                        var pdfBytes = System.IO.File.ReadAllBytes(filePath);


                        string relativePath = "recycle_news_en_pdf";
                        string currentDirectory = Directory.GetCurrentDirectory();


                        var fullPath = Path.Combine(dir, relativePath);
                        var pdfFileName = Path.GetFileName(new Uri(pdfUrl).LocalPath);
                        var pdfFilePath = Path.Combine(fullPath, pdfFileName);

                        await System.IO.File.WriteAllBytesAsync(pdfFilePath, pdfBytes);

                    }
                }
            }

            return Ok(newsList);
        }

        [HttpPost]
        [Route("MergeNewsImages")]
        public async Task<IActionResult> MergeNewsImages()
        {
            var oldImagesList = await _oldNewsRepo.GetAllNewsImages();
            var dir = _hostingEnvironment.WebRootPath;
            var newsList = new List<New_News_DTO>();
            var url = _configuration.GetSection("urlPath").Value;
            foreach (var item in oldImagesList)
            {
                #region Re Write AR Path
                string filePath = $"{dir}{item.News_IconLink}";
                string? arImgPath = null;

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    byte[] pdfBytes = System.IO.File.ReadAllBytes(filePath);
                    System.IO.File.WriteAllBytes(filePath, pdfBytes);
                    arImgPath = await ReWriteFilePath(filePath, "2");
                }
                #endregion

                var news = new News();
                if (arImgPath != null)
                {
                    #region Insert News
                    news.Brief = item.BriefAr;
                    news.IsPdf = false;
                    news.Image = arImgPath;
                    news.PublishDate = item.PublishDate;
                    news.Title = item.NameAr;
                    news.IsPublished = true;
                    news.IsDeleted = false;
                    news.Status = 3;

                    await _capmasContext.News.AddAsync(news);
                    await _capmasContext.SaveChangesAsync();
                    #endregion
                }
                //Store the failed ar img to recycle_news_ar_img
                else
                {
                    var imgUrl = $"{url}{item.News_IconLink}";
                    var imgBytes = System.IO.File.ReadAllBytes(filePath);

                    string relativePath = "recycle_news_ar_img";
                    string currentDirectory = Directory.GetCurrentDirectory();


                    var fullPath = Path.Combine(dir, relativePath);
                    var imgFileName = Path.GetFileName(new Uri(imgUrl).LocalPath);
                    var imgFilePath = Path.Combine(fullPath, imgFileName);

                    await System.IO.File.WriteAllBytesAsync(imgFilePath, imgBytes);

                }

                //Check If News Is Successfully added and the path is converted 
                if (news.Id != 0 && arImgPath is not null)
                {
                    #region Insert Translation 

                    var newsTranslation = new NewsTranslation();
                    newsTranslation.NewsId = news.Id;
                    newsTranslation.Locale = "en";
                    newsTranslation.Title = item.NameEn;
                    newsTranslation.Brief = item.BriefEn;
                    newsTranslation.PdfUrl = arImgPath;
                    await _capmasContext.NewsTranslations.AddAsync(newsTranslation);
                    await _capmasContext.SaveChangesAsync();
                    #endregion
                }
                //Store the failed en img to recycle_news_en_img
                else
                {
                    var imgUrl = $"{url}{item.News_IconLink}";


                    var imgBytes = System.IO.File.ReadAllBytes(filePath);


                    string relativePath = "recycle_news_en_img";
                    string currentDirectory = Directory.GetCurrentDirectory();


                    var fullPath = Path.Combine(dir, relativePath);
                    var imgFileName = Path.GetFileName(new Uri(imgUrl).LocalPath);
                    var imgFilePath = Path.Combine(fullPath, imgFileName);

                    await System.IO.File.WriteAllBytesAsync(imgFilePath, imgBytes);

                }
            }
            return Ok(oldImagesList);
        }

        [HttpPost]
        [Route("DownloadEgyptStatisticsJournalFiles")]
        public async Task<IActionResult> DownloadEgyptStatisticsJournalFiles()
        {
            var historyDetails = await _history_Details_Repo.GetAllHistoryDetails();
            var dir = _hostingEnvironment.WebRootPath;
            var url = _configuration.GetSection("urlPath").Value;
            
            foreach (var item in historyDetails)
            {
                var pdfURL = $"{url}/pdf/{item.PDF_En}";
                await DownloadAndSaveMagazinePdf(pdfURL);
            }
            return Ok();
        }

        [HttpPost]
        [Route("MergeEgyptStatisticsJournalFiles")]
        public async Task<IActionResult> MergeEgyptStatisticsJournalFiles()
        {

            var historyDetails = await _history_Details_Repo.GetAllHistoryDetails();
            var dir = _hostingEnvironment.WebRootPath;

             
            foreach (var item in historyDetails)
            {
                #region Insert EgyptStatisticsJournals

                #region Re Write Path AR
                string filePath = Path.Combine(dir, $"pdf/{item.PDF_Ar}");
                string? newPdfPath = null;
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {

                    byte[] pdfBytes = System.IO.File.ReadAllBytes($"{dir}/pdf/{item.PDF_Ar}");
                    System.IO.File.WriteAllBytes(filePath, pdfBytes);
                    newPdfPath = await ReWriteFilePath(filePath, "14");
                }
                #endregion


                var egy_statistics_journal = new EgyptStatisticsJournal();
                if (newPdfPath != null)
                {

                    egy_statistics_journal.Year = int.Parse(item.Year);
                    egy_statistics_journal.IsPdf = true;
                    egy_statistics_journal.Url = newPdfPath;
                    egy_statistics_journal.Title = item.titleAr;
                    egy_statistics_journal.IsPublished = true;
                    egy_statistics_journal.IsDeleted = false;
                    egy_statistics_journal.Status = 3;

                    await _capmasContext.EgyptStatisticsJournals.AddAsync(egy_statistics_journal);
                    await _capmasContext.SaveChangesAsync();
                }
                #endregion

                #region Insert Translation

                #region Re Write Path EN
                string fileENPath = Path.Combine(dir, $"pdf/{item.PDF_En}");
                string? enPdfPath = null;
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {

                    byte[] pdfENBytes = System.IO.File.ReadAllBytes($"{dir}/pdf/{item.PDF_En}");
                    System.IO.File.WriteAllBytes(fileENPath, pdfENBytes);
                    enPdfPath = await ReWriteFilePath(fileENPath, "14");
                }
                #endregion
                if (egy_statistics_journal.Id != 0 && enPdfPath != null)
                {

                    var egy_statistics_translation = new EgyptStatisticsJournalTranslation();
                    egy_statistics_translation.EgyptStatisticsJournalId = egy_statistics_journal.Id;
                    egy_statistics_translation.Locale = "en";
                    egy_statistics_translation.Title = item.titleEn;
                    egy_statistics_translation.PdfUrl = enPdfPath;


                    await _capmasContext.EgyptStatisticsJournalTranslations.AddAsync(egy_statistics_translation);
                    await _capmasContext.SaveChangesAsync();
                }

                #endregion


            }
            return Ok(historyDetails);
        }

    }
}
