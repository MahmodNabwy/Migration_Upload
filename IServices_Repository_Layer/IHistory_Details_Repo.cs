using Context.Old_Models;
using DTOS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices_Repository_Layer
{
    public interface IHistory_Details_Repo :IGenericRepository<HistoryDetail>
    {
        Task<List<History_Details_DTO>> GetAllHistoryDetails();
    }
}
