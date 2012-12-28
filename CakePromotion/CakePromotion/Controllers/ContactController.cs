//using CakePromo.BusinessLogic;
using CakePromotion.CakePromoService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace CakePromotion.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            //using (MainClient service = new MainClient())
            //{
                
            //}

            return View();
        }

        public ActionResult ContactEdit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactEdit(Cake model)
        {
            if (ModelState.IsValid)
            {
            }
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(string name, string email, string message)
        {
            bool emailSent = false;
            string msg = string.Empty;

            if (ModelState.IsValid)
            {
                try
                {
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(ConfigurationManager.AppSettings["emailUser"], ConfigurationManager.AppSettings["emailPass"])
                    };
                    using (var m = new MailMessage(ConfigurationManager.AppSettings["emailUser"], email)
                    {
                        Subject = ConfigurationManager.AppSettings["emailSubject"],
                        Body = message
                    })
                    {
                        smtp.Send(m);
                    }
                    emailSent = true;
                }

                catch (Exception ex)
                {
                    emailSent = false;
                    msg = ex.Message;
                    //Capture error when logging is ready
                    //throw;
                }
            }

            ViewBag.EmailSent = emailSent;
            ViewBag.Message = msg;

            return View();
        }
    }
}
