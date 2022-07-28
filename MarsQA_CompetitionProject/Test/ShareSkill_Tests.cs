
using MarsQA_CompetitionProject.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using static MarsQA_CompetitionProject.Global.GlobalDefinitions;


namespace MarsQA_CompetitionProject.Test
{
    public class ShareSkill_Tests
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {


            [Test, Order(1)]

            public void CreateShareSkill()
            {

                //Start the Reports
                test = extent.StartTest("Create ShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Created");

                //taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");

                //Create Share Skills      
                ShareSkill skillObj = new ShareSkill();
                skillObj.EnterShareSkill();
            }



            [Test, Order(2)]
            public void ViewRecord()
            {
                //Start the Reports
                test = extent.StartTest("ViewRecord");
                test.Log(LogStatus.Info, "ShareSkills Record Visible");

                // Take Screenshots 
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");

                // View ShareSkill record
                ManageListings manageListingsobj = new ManageListings();
                manageListingsobj.ViewShareSkill();
            }

            [Test, Order(3)]
            public void EditRecord()
            {
                //Start the Reports
                test = extent.StartTest("EditShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Edited");

                //taking Screenshots
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");

                // Edit ShareSkill record
                ManageListings manageListingsObj = new ManageListings();
                manageListingsObj.ManageListingsEditListingSteps();
            }

            [Test, Order(4)]
            public void DeleteRecord()
            {
                //Start the Reports
                test = extent.StartTest("DeleteShareSkill");
                test.Log(LogStatus.Info, "ShareSkills Record Deleted");

                //taking Screenshots 
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");

                // Delete ShareSkill record
                ManageListings manageListingsobj = new ManageListings();
                manageListingsobj.DeleteShareSkill();
            }
        }
    }
}
