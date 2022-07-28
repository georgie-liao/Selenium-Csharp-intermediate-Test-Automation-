
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsQA_CompetitionProject.Utilities
{
    public static class Wait
    {
        public static void WaitForWebElement(IWebDriver driver, string locatorValue, string elementLocator, int secondsToWait)
        {
            try
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, secondsToWait));
                if (elementLocator == "XPath")
                {

                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
                }
                if (elementLocator == "Id")
                {

                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
                }
                if (elementLocator == "CssSelector")
                {

                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
                }
                if (elementLocator == "Name")
                {

                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
                }
            }
            catch (Exception ex)
            {
                //Assert.Fail("Test failed as element was not available", ex.Message);
            }

        }

        public static bool WaitForElementDisplayed(this IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by)).Displayed);
        }

        public static IWebElement WaitForElementClickable(this IWebElement element, IWebDriver driver, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
