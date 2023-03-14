using ConsoleApp1;
using demoCCSupport.supportClasses;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace demoCCSupport.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        loginPageObjects loginObjects = new loginPageObjects();
        HomePageObjects homePageObjects = new HomePageObjects();
        CCSuportModuleObjects ccSupportModuleObject = new CCSuportModuleObjects();

        IWebDriver driver;

        public Feature1StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        

        [Given(@"I am at VCC login page\.")]
        public void GivenIAmAtVCCLoginPage_()
        {
            
            //propertiesCollection.driver.Navigate().GoToUrl(loginObjects.url);
            //......
            //driver= new ChromeDriver();
            //driver.Url = loginObjects.url;
            driver.Navigate().GoToUrl(loginObjects.url);
            Console.WriteLine("Open Url");
        }

        [When(@"I enter credentials\.")]
        public void WhenIEnterCredentials_()
        {
            seleniumSetMethod.EnterText(element: loginObjects.UsernameInputbarId, elementType  : ProperType.Id , value: loginObjects.Username ,driver:driver );
            seleniumSetMethod.EnterText(element: loginObjects.PasswordInputbarId, elementType: ProperType.Id, value: loginObjects.Password, driver: driver);
            seleniumSetMethod.Click(element: loginObjects.SubmitButtonXpath, elementType: ProperType.X_Path, driver: driver);
            
            Console.WriteLine(" 2ND  is DONE : ");

        }

        [Then(@"I get logged in\.")]
        public void ThenIGetLoggedIn_()
        {
            
            string username = "no name";
            Thread.Sleep(10000);
            
            
            username = seleniumSetMethod.GetText(element: homePageObjects.UsernameId, elementType:ProperType.Id, driver: driver);
            
            Console.WriteLine(" Username is  : " +  username);
            // "Super Admin"
            Assert.AreEqual("Super Admin", username);
            //Assert.AreEqual("super", username);
        }

        [When(@"I click on CCSupport\.")]
        public void WhenIClickOnCCSupport_()
        {
            seleniumSetMethod.Click(element: homePageObjects.CCSupportXPath, elementType: ProperType.X_Path, driver: driver);
            Thread.Sleep(10000);
        }

        [When(@"I click on add user button\.")]
        public void WhenIClickOnAddUserButton_()
        {
            seleniumSetMethod.Click(element: ccSupportModuleObject.AddNewUserButtonId, elementType:ProperType.Id, driver: driver);
            Thread.Sleep(10000);
        }

        [When(@"I enter Username\.")]
        public void WhenIEnterUsername_()
        {
            seleniumSetMethod.EnterText(element: ccSupportModuleObject.UsernameInputbarId, elementType: ProperType.Id,value:ccSupportModuleObject.Username ,driver: driver);
        }

        [When(@"I enter Email Address\.")]
        public void WhenIEnterEmailAddress_()
        {
            seleniumSetMethod.EnterText(element: ccSupportModuleObject.EmailInputbarId, elementType: ProperType.Id, value: ccSupportModuleObject.Email, driver: driver);
        }

        [When(@"I click on the profile tab\.")]
        public void WhenIClickOnTheProfileTab_()
        {
            seleniumSetMethod.Click(element: ccSupportModuleObject.ProfileTabId, elementType: ProperType.Id, driver: driver);
            Thread.Sleep(3000);
        }

        [When(@"I click the OK button\.")]
        public void WhenIClickTheOKButton_()
        {
            seleniumSetMethod.Click(element: ccSupportModuleObject.ProfileTabOkButtonID, elementType: ProperType.Id, driver: driver);
            Thread.Sleep(4000);
            try
            {
                seleniumSetMethod.Click(element: ccSupportModuleObject.UserReactivationButtonXpath, elementType: ProperType.X_Path, driver: driver);
            }
            catch( Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(10000);
        }

        [Then(@"The agent is successfully created\.")]
        public void ThenTheAgentIsSuccessfullyCreated_()
        {
            Console.WriteLine("The agent has been successfully created.");
        }




    }
}
