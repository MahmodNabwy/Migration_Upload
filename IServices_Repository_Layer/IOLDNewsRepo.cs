using Context.Old_Models;
using DTOS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices_Repository_Layer
{
    public interface IOLDNewsRepo : IGenericRepository<TblNews>
    {
        Task<List<OldNewsDTO>> GetAllNews();
        Task<List<oldNewsFilesDTO>> GetAllNewsFiles();
        Task<List<OldNewsImagesDTO>> GetAllNewsImages();
    }
}
