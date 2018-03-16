using System;
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
                    ViewBag.WhatsAppResponseMessage = "<p style='color: green;'>Thank you for Contacting us </p>";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.WhatsAppResponseMessage = $"<p style='color: red;'> Sorry we are facing Problem here {ex.Message}</p>";
                }
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(contactUsModel contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(contact.emailaddress);//Email which you are getting 
                    //from contact us page 
                    msz.To.Add("taumarch@gmail.con");//Where mail will be sent 
                    msz.Subject = "REF: MAIL FROM CLIENT CONTACT PAGE";
                    msz.Body = String.Format("Client: "+ contact.fullName+"\nEmail: "+contact.emailaddress+
                                             "\nCell: "+contact.contactNumber+
                                             "\nREF: MESSAGE FROM CLIENT CONTACT FORM"+
                                             "\nMessage : "+
                                             "\n"+contact.Message+
                                             "\n\nPlease respond if you can");
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                        ("massy19@gmail.com", "Busi@2631");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.contactErrorMessage = "";
                    ViewBag.contactMessage = "..... THANK YOU FOR CONTACTING US.....";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.contactMessage = "";
                    ViewBag.contactErrorMessage ="Sorry we are facing Problem here";
                }
            }
            

            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }
    }
}  