using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using JiaMiXiu.Domain.IRepository;
using JiaMiXiu.Model.Entity;

namespace JiaMiXiu.Domain.Repository
{	
    public partial class GradeRepository :  RepositoryBase<GradeEntity>, IGradeRepository
    {
	   
    }

}
