using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using G.A.Z.SIOS;
using G.A.Z.SIOS.Controllers;
using G.A.Z.SIOS.Models;

namespace G.A.Z.SIOS.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        [TestMethod]
        public void Dodaj_wydarzenie()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Dodaj_wydarzenie() as ViewResult;
            
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Dodaj_wydarzenie_HttpPost()
        {
            HomeController controller = new HomeController();

            EventViewModels obj = new EventViewModels();
            obj.Cena_wejsciowki = 0;
            obj.Data = DateTime.Now;
            obj.ID = 0;
            obj.ID_organizator = "User";
            obj.Image_id = 0;
            obj.Miejsce = "Place";
            obj.Nazwa = "Test";
            obj.Opinia_value = 0;
            obj.Opis = "test:";
            obj.Udzial_count = 0;
            obj.Zainteresowani_count = 0;

            Rodzaje rodzaje = new Rodzaje();
            obj.Rodzaj = rodzaje.Swiateczne.ToString();

            ViewResult result = controller.Dodaj_wydarzenie(new Objekty(obj, rodzaje)) as ViewResult;
            Assert.AreEqual("Dodaj_wydarzenie", result.ViewName);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        /*
        public bool EmailTest()
        {
            System.Net.Mail.MailMessage m = new System.Net.Mail.MailMessage(
                    new System.Net.Mail.MailAddress("sios.gaz@gmail.com", "Email confirmation"),
                    new System.Net.Mail.MailAddress("sebastian.trzeciak@student.wat.edu.pl"));
            m.Subject = "Potwierdź konto";
            m.IsBodyHtml = true;
            m.Body = "Test smtp connection";
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("sios.gaz@gmail.com", "qwerty!@#$%");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(m);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        [TestMethod]
        public void EmailTesting()
        {
            bool smtp_connection = EmailTest();
            Assert.IsTrue(smtp_connection);
        }

        [TestMethod]
        public void Register()
        {
            // Arrange
            AccountController controller = new AccountController();
            
            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ForgotPassword()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = controller.ForgotPassword() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Imprezy_studenckie()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Imprezy_studenckie() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Dodaj_wydarzenie()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Dodaj_wydarzenie() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Opinie_i_raporty()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Opinie_i_raporty() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        */
    }
}
