using AspMVC_WebErrorLog.Serilog.Utilities;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC_WebErrorLog.Serilog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private ILogger _errorlog;
        public ActionResult Index()
        {
            try
            {
                throw new NotImplementedException();
                

                //HelperStoreSqlLog.WriteDebug(null, "Debug ");
                //HelperStoreSqlLog.WriteWarning(null, "Warning ");
                //throw new NotImplementedException();

                //Helper.WriteDebug(null, "Debug ");
                //Helper.WriteWarning(null, "Warning ");
                //throw new NotImplementedException();
            }
            catch (Exception e)
            {
                // Webconfig settings
                _errorlog = new LoggerConfiguration()
                   .ReadFrom.AppSettings()
                   .CreateLogger();

                _errorlog.Error(e, "DefaultController");
                throw;

                // SQL 
                //HelperStoreSqlLog.WriteError(e, "Error");
                //HelperStoreSqlLog.WriteFatal(e, "Fatal");
                //HelperStoreSqlLog.WriteVerbose(e, "Verbose");
                //throw;


                // Txt File
                //Helper.WriteError(e, "Error");
                //Helper.WriteFatal(e, "Fatal");
                //Helper.WriteVerbose(e, "Verbose");
                //throw;
            }
            return View();
        }
    }
}