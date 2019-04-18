
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using ODataWithSwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataWithSwagger.Controllers
{
    [ODataRoutePrefix("Companies")]
    [ApiVersion("1.0")]
    public class CompaniesController: ODataController
    {
        private List<Company> companies = new List<Company>
        {
            new Company { Id = 0, Name = "A.C.M.E. Corp"},
            new Company { Id = 1, Name = "Microsoft Corp"}
        };

        [ODataRoute]
        [EnableQuery]
        public IQueryable<Company> Get() => companies.AsQueryable();
    }
}
