using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace AplicacaoSpecFlowBDD
{
    [Binding]
    public class DemoQaStepAcesso
    {
        private WebDriver driver;
       


        private const string url = "https://demoqa.com/";


        [Given(@"acesso a pagina demo QA")]
        public void GivenAcessoAPaginaDemoQA()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(url);
        }

        [When(@"clicar no menu Elements")]
        public void WhenClicarNoMenuElements()
        {
            driver.FindElement(By.ClassName("card-up")).Click();
        }

        [Then(@"acesso realizado com sucesso")]
        public void ThenAcessoRealizadoComSucesso()
        {
       
        }
      

    }
}
