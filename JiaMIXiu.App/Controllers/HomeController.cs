using JiaMiXiu.Model.Entity;
using JiaMiXiu.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JiaMIXiu.App.Controllers
{
    public class HomeController : ApiController
    {
        private ITestService service;

        public IHttpActionResult GetModel() {
         
            var model = service.GetModel();
            return Json<TestEntity>(model);
        }
    }
}
