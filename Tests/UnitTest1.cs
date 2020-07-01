using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace OrangeHRMJune2020
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
       
        [SetUp]
        public void BeforeEachTest()
        {
            // Initiating the driver
            // driver = new ChromeDriver();
            // Create an instance of Login Page

            var loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }

        [TearDown]
        public void AfterEachTest()
        {
            driver.Quit();
        }

        
        [Category("IntegrationTests")]
        [Test]        
        public void IT1_AddnValidate()
        {
            var dashboardPage = new DashBoardPage(driver);
            dashboardPage.ClickUsers();

            var systemUsersPage = new SystemUsersPage(driver);
            systemUsersPage.ClickAdd();
            systemUsersPage.AddAndSaveUser();
            systemUsersPage.VerifyUser();
        }
       
        [Test]
        public void IT3_DeletenValidate()
        {
            var dashboardPage = new DashBoardPage(driver);
            dashboardPage.ClickUsers();

            var systemUsersPage = new SystemUsersPage(driver);
            //create method & logic to delte
        }

        [Test]
        [Category("UnitTests")]
        public void IT2_EditnValidate()
        {
            Assert.Fail();
        }

    }
}