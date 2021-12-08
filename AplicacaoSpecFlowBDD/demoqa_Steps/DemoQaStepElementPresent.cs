using System;
using TechTalk.SpecFlow;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AplicacaoSpecFlowBDD
{
    [Binding]
    public class DemoQaStepElementPresent


    {
        private WebDriver driver;
       
        private const string url = "https://demoqa.com/";


        [Given(@"Acesso realizado a pagina elements")]
        public void GivenAcessoRealizadoAPaginaElements()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(url);
            

        }

        [When(@"Acessar a pagina")]
        public void WhenAcessarAPagina()
        {
            driver.FindElement(By.ClassName("card-up")).Click();
        }

        [Then(@"validar todos button '([^']*)'")]
        public void ThenValidarTodosButton(string presente, Table table)
        {
            bool isElementDisplayed = driver.FindElement(By.ClassName("header-wrapper")).Enabled;
        }
    }
}
