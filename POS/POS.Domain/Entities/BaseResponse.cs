using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Entities
{
    public class BaseResponse<T>
    {
        public BaseResponse() {
            this.IsSuccess = false;
            this.Message = string.Empty;
            this.ResponseCode = HttpStatusCode.OK;
            this.Data = default;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public HttpStatusCode ResponseCode { get; set; }
        public T Data { get; set; }


    }
}
