using MarsQA_CompetitionProject.Global;
using MarsQA_CompetitionProject.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System.Threading;
using static MarsQA_CompetitionProject.Global.GlobalDefinitions;
using OpenQA.Selenium;
using System;

namespace MarsQA_CompetitionProject.Test
{

    public class ShareSkill_Tests
    {
       

        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            #region  Test 1 : Create Share Skill
            [Test, Order(1)]
            public void CreateShareSkill()
            {

                //Start the Reports
                test = extent.StartTest("Create ShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Created");

                // Take Screenshots of entering Share Skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");

                // Enter Share Skill steps    
                ShareSkill ShareSkillObj = new ShareSkill();
                ShareSkillObj.EnterShareSkill_Steps();

                GlobalDefinitions.wait(10);

                // Click Manage listing button to see the newly entered Share Skill record
                driver.FindElement(By.LinkText("Manage Listings")).Click();
             
                GlobalDefinitions.wait(10);

                // Assert the the newly created Share Skill record by comparing the the first record value with the excel data value
                string NewCategory = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).Text;
                Assert.AreEqual(NewCategory, ExcelLib.ReadData(2, "Category"));

                string NewTitle = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).Text;
                Assert.AreEqual(NewTitle, ExcelLib.ReadData(2, "Title"));

                string NewDescription = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")).Text;
                Assert.AreEqual(NewDescription, ExcelLib.ReadData(2, "Description"));
                Assert.AreEqual("ListingManagement", GlobalDefinitions.driver.Title);

                // Display messge of test result.
                Console.WriteLine("Test Passed");
            }
            #endregion

            #region  Test 2 : View Share Skill record
            [Test, Order(2)]
            public void ViewRecord()
            {
                //Start the Reports
                test = extent.StartTest("ViewRecord");
                test.Log(LogStatus.Info, "ShareSkills Record Visible");

                // Take Screenshots 
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");

                // Edit ShareSkill record object
                ManageListings ManageListingsObj = new ManageListings();
               // View the newly entered share skill record
                ManageListingsObj.ViewShareSkill_Steps();

                GlobalDefinitions.wait(10);

                // Assert the the newly created Share Skill record by comparing the the first record value with the excel data value
                string ViewTitle = GlobalDefinitions.driver.FindElement(By.XPath("//div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")).Text;
                Assert.AreEqual(ViewTitle, ExcelLib.ReadData(2, "Title"));

                string ViewDescription = GlobalDefinitions.driver.FindElement(By.XPath("//div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]")).Text;
                Assert.AreEqual(ViewDescription, ExcelLib.ReadData(2, "Description"));

                string ViewCategory = GlobalDefinitions.driver.FindElement(By.XPath("//div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[2]")).Text;
                Assert.AreEqual(ViewCategory, ExcelLib.ReadData(2, "Category"));

                // Display test result
                Console.WriteLine("Test Passed");
            }
            #endregion

            #region  Test 3 : Edit Share Skill record
            [Test, Order(3)]
            public void EditShareKill()
            {
                //Start the Reports
                test = extent.StartTest("EditShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Edited");

                //taking Screenshots
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");

                // Edit ShareSkill record object
                ManageListings ManageListingsObj = new ManageListings();
                ManageListingsObj.EditShareSkill_Action();

                Thread.Sleep(2000);

                // Assert the the edited record by comparing the the record value with the excel data value
                GlobalDefinitions.wait(10);
                string EditedCategory = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).Text;
                Assert.AreEqual(EditedCategory, ExcelLib.ReadData(2, "Category"));

                string EditedTitle = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).Text;
                Assert.AreEqual(EditedTitle, ExcelLib.ReadData(2, "Title"));

                string EditedDescrption = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]")).Text;
                Assert.AreEqual(EditedDescrption, ExcelLib.ReadData(2, "Description"));
           
                // Display test result message
                Console.WriteLine("Record Edited Successfully");
            }
            #endregion

            #region  Test e : Delete Share Skill record
            [Test, Order(4)]
            public void DeleteRecord()
            {
                // Start the Reports
                test = extent.StartTest("DeleteShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Deleted");

                //taking Screenshots 
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");

                // Edit ShareSkill record object
                ManageListings ManageListingsObj = new ManageListings();
                ManageListingsObj.DeleteShareSkill_Steps();

                GlobalDefinitions.wait(5);

                // Assert the pop-message
                string message = (GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"))).Text;
                GlobalDefinitions.wait(5);
                if (message.Contains("has been deleted")) // If the pop-up message contains 
                {
                    Console.WriteLine("Test passed"); // Then display this message
                }
                else
                {
                    Console.WriteLine("Test failed"); // Else display this message
                }
            }
            #endregion
        }
    }
}
