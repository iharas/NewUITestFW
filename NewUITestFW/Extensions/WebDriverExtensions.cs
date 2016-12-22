using System;
using OpenQA.Selenium;

namespace NewUITestFW.Extensions
{
    internal static class WebDriverExtensions
    {
        public static void WaitForPageIsLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {
                var state = dri.ExecuteJS("return document.readyState").ToString();
                return state == "complete";
            }, 10);
        }

        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeout)
        {

            Func<T, bool> execute = (arg) =>
            {
                try
                {
                    return condition(arg);
                }
                catch (Exception e)
                {

                    throw;
                }
            };
        }

        public static object ExecuteJS(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
    }
}
