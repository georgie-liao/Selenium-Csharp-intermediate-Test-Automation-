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
        #region  Objects 
        // Edit Share Skill record steps
        ShareSkill ShareSkillPage = new ShareSkill();
        #endregion

        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Manage Listing web element

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

        #endregion


        #region View Share Skill
        public void ViewShareSkill_Steps()
        {
            // Import value from excel data file
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            // Wait for Manage List tab is clickable then click
            ManageListingsTab.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            ManageListingsTab.Click();

            // Wait for view button is clickable then click
            ViewIcon.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            ViewIcon.Click();
            GlobalDefinitions.wait(2);
        }
        #endregion


        #region Edit Share Skill
        public void EditShareSkill_Action()
        {
            // Wait for Manage List tab is clickable then click
            ManageListingsTab.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            ManageListingsTab.Click();

            GlobalDefinitions.wait(10);

            // Click on the Edit icon then edit the record 
            EditIcon.Click();

            GlobalDefinitions.wait(10);

            // Edit Share skill 
            ShareSkillPage.EditShareSkill_Steps();
        }
        #endregion


        #region Delete Share Skill
        public void DeleteShareSkill_Steps()
        {
            // Wait for Manage Listings tab is clickable then click
            ManageListingsTab.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            ManageListingsTab.Click();

            //Identify and click on delete button
            DeleteIcon.WaitForElementClickable(Global.GlobalDefinitions.driver, 60);
            DeleteIcon.Click();

            GlobalDefinitions.wait(2);

            // Switch to Pop-up alert message then click on Yes button to confirm deletion
            YesBtn.WaitForElementClickable(GlobalDefinitions.driver, 60);
            YesBtn.Click();
        }
        #endregion
    }
}
