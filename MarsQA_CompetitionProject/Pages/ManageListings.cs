using MarsQA_CompetitionProject.Global;
using MarsQA_CompetitionProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using static MarsQA_CompetitionProject.Global.GlobalDefinitions;


namespace MarsQA_CompetitionProject.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        // Virify Manage Listing tab
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement ManageListingsTab { get; set; }

        // View record icon
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement ViewIcon { get; set; }

        // Delete recrod icon 
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")]
        private IWebElement DeleteIcon { get; set; }

        // Edit reco
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement EditIcon { get; set; }

        // Yes button on the pop up alert window
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement YesBtn { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");

        }

        public void ManageListingsEditListingSteps()
        {
            // Wait for Manage List tab is clickable then click
            ManageListingsTab.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);

            ManageListingsTab.Click();
            GlobalDefinitions.wait(10);


            // Click on the Edit icon then edit the record 
            EditIcon.Click();

            GlobalDefinitions.wait(10);

            // Edit Share Skill record steps
            ShareSkill ShareSkillPage = new ShareSkill();
            ShareSkillPage.EditShareSkill();
        }

        public void DeleteShareSkill()
        {
            // Wait for Manage Listings tab is clickable then click
            ManageListingsTab.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            ManageListingsTab.Click();

            //Identify and click on delete button
            DeleteIcon.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            DeleteIcon.Click();

            GlobalDefinitions.wait(2);

            // Switch to Pop-up alert message then click on Yes button
            YesBtn.WaitForElementClickable(GlobalDefinitions.driver, 60);
            YesBtn.Click();

            GlobalDefinitions.wait(2);

            // Assert the pop-message
            string message = (GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"))).Text;
            GlobalDefinitions.wait(5);
            if (message.Contains("has been deleted"))
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

        }

        public void ViewShareSkill()
        {
            // Wait for Manage List tab is clickable then click
            ManageListingsTab.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            ManageListingsTab.Click();

            // Wait for view button is clickable then click
            ViewIcon.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            ViewIcon.Click();
            GlobalDefinitions.wait(2);
        }
    }
}
