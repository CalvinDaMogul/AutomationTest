using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace NewConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();


            driver.Navigate().GoToUrl("http://hpa.services/automation-challenge/");
            //Step 1
            IWebElement BoxParagraph1 = driver.FindElement(By.Id("BoxParagraph1"));

            BoxParagraph1.Click();

            System.Threading.Thread.Sleep(2000);

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
           
            //Step 2
            IWebElement Box3 = driver.FindElement(By.Id("Box3"));
            Box3.SendKeys(Keys.Tab);

            System.Threading.Thread.Sleep(2000);

            IAlert alert2 = driver.SwitchTo().Alert();
            alert.Accept();

            //Step3
            IWebElement Box4 = driver.FindElement(By.Id("BoxParagraph2"));
            IWebElement optionVal = driver.FindElement(By.XPath("//*[@type='radio'][2]"));
            optionVal.Click();

            System.Threading.Thread.Sleep(2000);


            IAlert alert3 = driver.SwitchTo().Alert();
            alert.Accept();

            //Step4
            IWebElement Step4Element = driver.FindElement(By.Id("BoxParagraph4"));
            SelectElement selectElement = new SelectElement(Step4Element.FindElement(By.XPath(".//select")));
            selectElement.SelectByText(driver.FindElement(By.Id("selectionVal")).GetAttribute("innerHTML"));

            System.Threading.Thread.Sleep(2000);


            IAlert alert4 = driver.SwitchTo().Alert();
            alert.Accept();

            //Step5
            IWebElement Step1Element = driver.FindElement(By.Id("formDate"));
            Step1Element.Click();
            Step1Element.SendKeys("2017-05-04");

            IWebElement Step2Element = driver.FindElement(By.Id("formCity"));
            Step2Element.Click();
            Step2Element.SendKeys("Nashville");

            IWebElement Step3Element = driver.FindElement(By.Id("formState"));
            Step3Element.Click();
            Step3Element.SendKeys("Tennessee");

            IWebElement StepDElement = driver.FindElement(By.Id("formDate"));
            StepDElement.Click();
            StepDElement.SendKeys("2009-08-26");




            Console.ReadKey();

        }
    }
}
