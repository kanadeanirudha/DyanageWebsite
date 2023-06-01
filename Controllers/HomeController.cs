using Dynage.Models;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace Dynage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Active = "home";
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Active = "aboutus";
            return View();
        }

        public ActionResult ContactUs()
        {
            ViewBag.Active = "contactus";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Active = "services";
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(ContactUsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress(ConfigurationManager.AppSettings["MailFrom"].ToString(), ConfigurationManager.AppSettings["MailFrom_Name"].ToString());
                    var receiverEmail = new MailAddress(model.Email, model.Name);
                    var password = ConfigurationManager.AppSettings["Password"].ToString();
                    var sub = model.Name + " wants to connect with you";
                    var body = string.Format(@"Name :{0} 
                                 Phone: {1}
                                 Email : {2}
                                 Country : {3}
                                 Message : {4}",model.Name,model.PhoneNumber,model.Email,model.Country,model.Message);
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = sub,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                        TempData["success"] = "Thank you for contacting us...";
                    }
                    return RedirectToAction(nameof(ContactUs));
                }
            }
            catch (Exception e)
            {
                
            }
            TempData["error"] = "Failed to connect, Kindly verify the details";
            return RedirectToAction(nameof(ContactUs));
        }
    }
}