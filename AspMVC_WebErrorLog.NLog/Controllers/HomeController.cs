
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC_WebErrorLog.NLog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index()
        {
            try
            {
                Logger.Debug("Hi I am NLog Debug Level");
                Logger.Info("Hi I am NLog Info Level");
                Logger.Warn("Hi I am NLog Warn Level");
                throw new NullReferenceException();
                return View();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Hi I am NLog Error Level");
                Logger.Fatal(ex, "Hi I am NLog Fatal Level");
                throw;
            }
        }
    }
}