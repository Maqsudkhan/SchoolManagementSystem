using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Domain.Entities
{
    public class ResponseModel
    {
        public string Massege { get; set; }
        public int StatusCode { get; set; }
        public bool isSuccess { get; set; } = false;
    }
}
