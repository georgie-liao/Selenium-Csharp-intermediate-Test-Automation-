using MarsQA_CompetitionProject.Global;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;
using MarsQA_CompetitionProject.Utilities;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using static MarsQA_CompetitionProject.Global.GlobalDefinitions;
using SeleniumExtras.PageObjects;

namespace MarsQA_CompetitionProject.Pages
{
    public class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Share Skill web elements

        // Verify ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillBtn { get; set; }

        // Verify Title textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement TitleTextbox { get; set; }

        // Verify Description textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement DescriptionTextbox { get; set; }

        // Verify Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        // Verify SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        // Verify Tag textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement TagsTextbox { get; set; }

        // Verify Tag Removal button 
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[4]/div[2]/div/div/div/span/a")]
        private IWebElement TagsRemovalBtn { get; set; }

        // Verify Service type options
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        // Select the Hourly Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement HourlyServiceType { get; set; }

        // Select On-Off Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement OneOffServiceType { get; set; }

        // Verify the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        // Select On-Site Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        public IWebElement OnSiteLocationType { get; set; }

        // Select Online Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement OnlineLocationType { get; set; }

        // Verify Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        // Verify End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        // Store the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        // Store the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        // Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        // Verify EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement Credit { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillExchange { get; set; }

        //Enter Skill Exchange tag
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchangeTag { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Find Active Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement ActiveButton { get; set; }

        //Find Hidden Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement HiddenButton { get; set; }

        //Click on Work Sample button
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement WorkSampleBtn { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement SaveBtn { get; set; }

        #endregion


        #region  Service type 
        public void ServiveType() // Select service type
        {
            // Import data from the excel file
            String ServiceType = ((GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType")));

            // Select service type
            if (ServiceType.Equals("Hourly basis service"))
            {
                HourlyServiceType.Click();
            }
            else if (ServiceType.Equals("One-off service"))
            {
                OneOffServiceType.Click();
            }
        }
        #endregion

        #region  Location type 
        public void LocationType() // Set location typle
        {
            // Import data from the excel file
            String LocationType = ((GlobalDefinitions.ExcelLib.ReadData(2, "LocationType")));

            // Select location type
            if (LocationType.Equals("On-site"))
            {
                OnSiteLocationType.Click();
            }
            else if (LocationType.Equals("Online"))
            {
                OnlineLocationType.Click();
            }
        }
        #endregion

        #region  Available days, start and end date, start and end time
        public void AvailableDays() // Set Available days
        {
            // Set available days
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));
            String[] WeekDays = new String[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            IList<IWebElement> AvailableCheckboxes = Days.FindElements(By.Name("Available"));
            String AvailableDaysValue = GlobalDefinitions.ExcelLib.ReadData(2, "SelectDay");
            IList<String> AvailableDays = AvailableDaysValue.Split(',');
            for (int i = 0; i < WeekDays.Count(); i++)
            {
                if (AvailableDays.Contains(WeekDays[i]))
                {
                    AvailableCheckboxes[i].Click();
                }
            }
            
            // Set Start times
            IList<IWebElement> AvailableStartTimeInputs = Days.FindElements(By.Name("StartTime"));
            String AvailableStartTimesValue = GlobalDefinitions.ExcelLib.ReadData(2, "StartingTime");
            IList<String> AvailableStartTimes = AvailableStartTimesValue.Split(',');
            for (int i = 0; i < AvailableStartTimes.Count(); i++)
            {
                IList<String> startTimeInfo = AvailableStartTimes[i].Split(':');
                String startTimeDay = startTimeInfo[0];
                String startTimeValue = startTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, startTimeDay);
                AvailableStartTimeInputs[indexOfDay].SendKeys(startTimeValue);
            }
            
            // Set End time
            IList<IWebElement> AvailableEndTimeInputs = Days.FindElements(By.Name("EndTime"));
            String AvailableEndTimesValue = GlobalDefinitions.ExcelLib.ReadData(2, "EndingTime");
            IList<String> AvailableEndTimes = AvailableEndTimesValue.Split(',');
            for (int i = 0; i < AvailableEndTimes.Count(); i++)
            {
                IList<String> endTimeInfo = AvailableEndTimes[i].Split(':');
                String endTimeDay = endTimeInfo[0];
                String endTimeValue = endTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, endTimeDay);
                AvailableEndTimeInputs[indexOfDay].SendKeys(endTimeValue);
            }
        }
        #endregion

        #region  Skill trade type
        public void SkillTrade() // Set Skill Trade type
        {
            // Import data from excel file
            String SkillTradeType = GlobalDefinitions.ExcelLib.ReadData(2, "SkillTradeType");

            // Select skill trade type 
            if (SkillTradeType.Equals("Skill-exchange"))
            {
                SkillExchange.Click();
                SkillExchangeTag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchangeTag"));
                SkillExchangeTag.SendKeys(Keys.Enter);
            }
            else if (SkillTradeType.Equals("Credit"))
            {
                Credit.Click();
                CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CreditAmount"));
            }
        }
        #endregion

        #region Active type
        public void ActiveType() // Set Active tuype
        {
            // Import Status data from excel file
            String ActiveType = GlobalDefinitions.ExcelLib.ReadData(2, "Status");
            
            // Select active type
            if (ActiveType.Equals("Active"))
            {
                ActiveButton.Click();
            }
            else if (ActiveType.Equals("Hidden"))
            {
                HiddenButton.Click();
            }
        }
        #endregion

        #region Work Sample upload
        public void WorkSampleUpload() // Upload Work Sample 
        {
            // Click on worksample button and upload sample file
            WorkSampleBtn.Click();

            Thread.Sleep(2000);

            // AutoIt file upload
            using (Process exeProcess = Process.Start(@"E:\MVP Studio\PROJECTS\MarsQA_CompetitionProject\FileUpload\AutoItFileUpload.exe"))
            {
                exeProcess.WaitForExit();
            }
           
            Thread.Sleep(2000);
        }
        #endregion

        #region Enter new Share Skill steps
        public void EnterShareSkill_Steps() // Enter new Share Skill steps
        {

            // Wait for Share Kill button is clickable then click 
            ShareSkillBtn.WaitForElementClickable(GlobalDefinitions.driver, 60);
            ShareSkillBtn.Click();

            // Import value from excel data file
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            // Enter title 
            TitleTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            // Enter description
            DescriptionTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            // Click on category dropdown and Select category
            CategoryDropDown.Click();
            SelectElement selectCategory = new SelectElement(CategoryDropDown);
            selectCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            // Click on subcategory dropdown and select subcategory
            SubCategoryDropDown.Click();
            SelectElement selectSubCategory = new SelectElement(SubCategoryDropDown);
            selectSubCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

            // Enter tags
            TagsTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            TagsTextbox.SendKeys(Keys.Enter);

            // Select Service Type
            ServiveType();

            // Select Location Type
            LocationType();

            // Select Available days
            AvailableDays();

            // Select Skill Trade type
            SkillTrade();

            // Upload Work Sample
            WorkSampleUpload();

            // Select Active type
            ActiveType();

            // Click Save button to save the newly entered Share Skill 
            SaveBtn.Click();
        }
        #endregion

        #region Edit Share Skill steps
        public void EditShareSkill_Steps()
        {
            // Import value from excel data file
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "EditShareSkill");

            // Clear Title textbox then enter new value
            TitleTextbox.Clear();
            TitleTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            // Clear description textbox then enter new value
            DescriptionTextbox.Clear();
            DescriptionTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            // Click on category dropdown then select new calue
            CategoryDropDown.Click();
            SelectElement selectCategory = new SelectElement(CategoryDropDown);
            selectCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            // Click on subcategory dropdown then select new calue
            SubCategoryDropDown.Click();
            SelectElement selectSubCategory = new SelectElement(SubCategoryDropDown);
            selectSubCategory.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

            // Remove existing tag then enter new tage
            TagsRemovalBtn.Click();
            TagsTextbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            TagsTextbox.SendKeys(Keys.Enter);

            // Select new Service Type
            ServiveType();

            // Select new Location Type
            LocationType();

            // Select new Available days
            AvailableDays();

            // Select new Skill Trade type
            SkillTrade();

            // Upload Work Sample
            WorkSampleUpload();

            GlobalDefinitions.wait(10);

            // Select new Active type
            ActiveType();

            // Click Save button to save the newly entered Share Skill 
            SaveBtn.Click();
        }
        #endregion
    }
}



