using Common.Logging;
using DemoApp.Models;
using DemoApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DemoApp.Controllers
{
    public class DemoApiController : ApiController
    {
        protected ILog log = LogManager.GetLogger(typeof(DemoApiController));

        public IDemoService DemoService { get; set; }

        // GET api/depts
        [Route("api/depts")]
        [HttpGet]
        public ApiResult GetDepts()
        {
            log.Debug("GetDepts()...");
            try
            {
                var depts = DemoService.GetAllDepts();
                return ApiResult.SuccessResult(depts);
            }
            catch (Exception e)
            {
                return ApiResult.ErrorResult(e.Message);
            }
        }

        // GET api/depts/10
        [Route("api/depts/{id:int}")]
        [HttpGet]
        public ApiResult GetDept(int id)
        {
            log.Debug("GetDept()..." + id);
            try
            {
                var dept = DemoService.GetDept(id);
                log.Debug("dept=" + dept);
                if (dept == null)
                {
                    throw new Exception(string.Format("Dept #{0} was not found", id));
                }
                return ApiResult.SuccessResult(dept);
            }
            catch (Exception e)
            {
                return ApiResult.ErrorResult(e.Message);
            }
        }

        // GET api/emps/7499
        [Route("api/emps/{id:int}")]
        [HttpGet]
        public ApiResult GetEmp(int id)
        {
            log.Debug("GetEmp()..." + id);
            try
            {
                var emp = DemoService.GetEmp(id);
                log.Debug("emp=" + emp);
                if (emp == null)
                {
                    throw new Exception(string.Format("Emp #{0} was not found", id));
                }
                return ApiResult.SuccessResult(emp);
            }
            catch (Exception e)
            {
                return ApiResult.ErrorResult(e.Message);
            }
        }

        // POST api/emps
        [Route("api/emps")]
        [HttpPost]
        public ApiResult CreateEmp(Emp emp) {
            log.Debug("CreateEmp()..." + emp);
            try
            {
                DemoService.SaveEmp(emp);
                log.Debug("emp=" + emp);
                return ApiResult.SuccessResult(emp, string.Format("Emp #{0} was created", emp.EmpNo));
            }
            catch (Exception e)
            {
                return ApiResult.ErrorResult(e.Message);
            }
        }
    }
}