using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.Controllers
{
    public class ApiResult
    {
        public const string STATUS_OK = "0";
        public const string STATUS_ERROR = "1";

        public string Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public static ApiResult SuccessResult(object data, string message = null)
        {
            var apiResult = new ApiResult();
            apiResult.Status = STATUS_OK;
            apiResult.Message = message;
            apiResult.Data = data;
            return apiResult;
        }

        public static ApiResult ErrorResult(string message)
        {
            var apiResult = new ApiResult();
            apiResult.Status = STATUS_ERROR;
            apiResult.Message = message;
            return apiResult;
        }
    }
}