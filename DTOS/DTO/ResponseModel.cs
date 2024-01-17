using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.DTO
{
    public class ResponseModel
    {
        public FilePath[] FilePath { get; set; }
        public bool State { get; set; }
    }
    public class FilePath
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string FileName { get; set; }
        public string Thumbnail { get; set; }
    }
}
