using System;
using JiaMiXiu.Model.Entity;
using System.Collections.Generic;
using JiaMiXiu.Domain.IRepository;
using JiaMiXiu.Domain.Repository;
using JiaMiXiu.Service.IService;

namespace JiaMiXiu.Service.Service
{	
    public partial class TestService: ITestService
    {
        public TestEntity GetModel()
        {
            return repository.QueryFirst(p => true);
        }
    }
}
