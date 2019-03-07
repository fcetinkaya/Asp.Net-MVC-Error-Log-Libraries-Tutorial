using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC_WebErrorLog.Log4net.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(HomeController));
        public ActionResult Index()
        {
            try
            {
                Log.Debug("Hi I am log4net Debug Level");
                Log.Info("Hi I am log4net Info Level");
                Log.Warn("Hi I am log4net Warn Level");
                throw new NullReferenceException();
                return View();
            }
            catch (Exception ex)
            {
                Log.Error("Hi I am log4net Error Level", ex);
                Log.Fatal("Hi I am log4net Fatal Level", ex);
                throw;
            }           
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