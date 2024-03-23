using AydinHotel.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace AydinHotel.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Hotelier'in Admini Hüseyin AYDIN Reisten!", "huseyinkursemail@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("Kullanıcı", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("huseyinkursemail@gmail.com", "burası gmail'in tokeni olacak!");
            client.Send(mimeMessage);
            client.Disconnect(true);

            //Gönderilen Mailin Veri Tabanına Kaydedilmesi.
            return View();
        }
    }
}