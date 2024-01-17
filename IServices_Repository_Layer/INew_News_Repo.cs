using Context.Capmas_Test;
using DTOS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices_Repository_Layer
{
    public interface INew_News_Repo : IGenericRepository<News>
    {
        Task<List<New_News_DTO>> GetAllNews();
    }
}
