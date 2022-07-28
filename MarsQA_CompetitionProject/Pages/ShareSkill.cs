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

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsBtn { get; set; }


        public void EnterShareSkill()
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

            // Select service type
            String ServiceType = ((GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType")));
            if (ServiceType.Equals("Hourly basis service"))
            {
                HourlyServiceType.Click();
            }
            else if (ServiceType.Equals("One-off service"))
            {
                OneOffServiceType.Click();
            }

            //Select Location Type
            String LocationType = ((GlobalDefinitions.ExcelLib.ReadData(2, "LocationType")));
            if (LocationType.Equals("On-site"))
            {
                OnSiteLocationType.Click();
            }
            else if (LocationType.Equals("Online"))
            {
                OnlineLocationType.Click();
            }
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));

            // String weekdays
            String[] WeekDays = new String[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // Click weekday checkboxes
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

            // Set Skill Trade by entering Skill Exchange Type and credit 
            String SkillTradeType = GlobalDefinitions.ExcelLib.ReadData(2, "SkillTradeType");
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

            // Click on worksample button and upload sample file
            WorkSampleBtn.Click();
            Thread.Sleep(5000);
            GlobalDefinitions.wait(10);
            using (Process exeProcess = Process.Start(@"E:\MVP Studio\PROJECTS\MarsQA_CompetitionProject\FileUpload\AutoItFileUpload.exe"))
            {
                exeProcess.WaitForExit();
            }
            Thread.Sleep(5000);
            GlobalDefinitions.wait(10);

            // Select Active type
            String ActiveType = GlobalDefinitions.ExcelLib.ReadData(2, "Status");
            if (SkillTradeType.Equals("Active"))
            {
                ActiveButton.Click();
            }
            else if (SkillTradeType.Equals("Hidden"))
            {
                HiddenButton.Click();
            }

            // Click Save button 
            GlobalDefinitions.wait(10);
            SaveBtn.Click();
            Thread.Sleep(5000);
            Thread.Sleep(5000);
            // Click Manage listing button to see the record
            GlobalDefinitions.wait(10);
            manageListingsBtn.Click();
            GlobalDefinitions.wait(2);
            Thread.Sleep(5000);
            // Assert the the newly created record by comparing the the first record value with the excel data value
            string searchInput1 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).Text;
            Assert.AreEqual(searchInput1, ExcelLib.ReadData(2, "Category"));
            string searchInput2 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).Text;
            Assert.AreEqual(searchInput2, ExcelLib.ReadData(2, "Title"));

            string searchInput3 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")).Text;
            Assert.AreEqual(searchInput3, ExcelLib.ReadData(2, "Description"));
            Assert.AreEqual("ListingManagement", GlobalDefinitions.driver.Title);

            Console.WriteLine("Test Passed");
        }


        public void EditShareSkill()
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

            // Click on Save button to save changes
            SaveBtn.Click();

            // Assert the the amended record by comparing the the first record value with the excel data value
            GlobalDefinitions.wait(10);
            string searchInput1 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).Text;
            Assert.AreEqual(searchInput1, ExcelLib.ReadData(2, "Category"));
            string searchInput2 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).Text;
            Assert.AreEqual(searchInput2, ExcelLib.ReadData(2, "Title"));

            string searchInput3 = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")).Text;
            Assert.AreEqual(searchInput3, ExcelLib.ReadData(2, "Description"));
            Assert.AreEqual("ListingManagement", GlobalDefinitions.driver.Title);

            Console.WriteLine("Record Edited Successfully");
        }
    }
}



