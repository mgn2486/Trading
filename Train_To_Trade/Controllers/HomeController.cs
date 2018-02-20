﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Train_To_Trade.Models;

namespace Train_To_Trade.Controllers
{
    public class HomeController : Controller
    {
        [System.Web.Http.HttpPost]
        public ActionResult Index(WhatsAppModel WatsApp)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(WatsApp.emailaddress);//Email which you are getting 
                    //from contact us page 
                    msz.To.Add("massy19@gmail.com");//Where mail will be sent 
                    msz.Subject = "Client Request to join the WhatsApp Group";
                    msz.Body = String.Format("Please may you kindly add me to the Whats up Group \n Name: {0} , {1} \n Cell : {2}", WatsApp.firstName, WatsApp.lastName, WatsApp.whatsAppCell);
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                        ("massy19@gmail.com", "Busi@2631");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.WhatsAppResponseMessage = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.WhatsAppResponseMessage = $" Sorry we are facing Problem here {ex.Message}";
                }
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