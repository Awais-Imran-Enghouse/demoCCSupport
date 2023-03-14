using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoCCSupport.supportClasses
{
      class loginPageObjects
    {

        public string url = "http://pkrd-aim-vcc.vcc.bel.rd.eilab.biz/VccWebCenter/Login.aspx";
        public string UsernameInputbarId = "txtUsername";
        public string PasswordInputbarId = "txtPassword";
        public string Username = "superadmin";
        public string Password = "superadmin";
        public string SubmitButtonXpath = "//*[@id=\"lbtLoginSubmit\"]/span";
       
    }
    class HomePageObjects
    {
        public string UsernameId = "menuHeaderUser";
        public string CCSupportXPath = "(//a[@title=\"CCSUPPORT\"])[2]";
        
    }
    class CCSuportModuleObjects
    {
        public string AddNewUserButtonId = "btnNew";
        public string UsernameInputbarId = "txtUsername";
        public string EmailInputbarId = "txtEmail";
        public string ProfileTabId = "ui-id-12";
        public string Username = "Dummy Agent2";
        public string Email = "Dummyagent2@grr.la";
        public string ProfileTabOkButtonID = "btnSave";
        public string UserReactivationButtonXpath = "(//button[@class=\'voxui-button voxui-default ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only\'])[2]";

    }

}
