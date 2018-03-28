using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;

namespace MVCPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // TODO use interface with dapper to make following syntax valid
            // var repository = x.y().getZ(IDapper);
            // repository.Query<Model>("Select * From Model");

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                var foo = db.Query<Model>("Select * From Model");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}