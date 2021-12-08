using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.IO;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumWebDriver.Steps
{
    [Binding]
    public class AccountRegistrationStepDef
    {
        private WebDriver driver;

        private IWebElement element;
        private string text;

        private const string Username = "elton@cit.com";
        private const string Password = "123456";

        [Given(@"que estou logado na aplicação")]
        public void GivenQueEstouLogadoNaAplicacao()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://seubarriga.wcaquino.me/");
            driver.FindElement(By.Id("email")).SendKeys(Username);
            driver.FindElement(By.Id("senha")).SendKeys(Password);
            driver.FindElement(By.TagName("button")).Click();
            element = driver.FindElement(By.XPath("/html/body/div[1]"));
            text = element.Text;
            Assert.AreEqual("Bem vindo, Elton!", text);
        }

        [When(@"cadastro a conta (.*)")]
        public void WhenCadastroAContaConta(string conta)
        {
            driver.FindElement(By.LinkText("Contas")).Click();
            driver.FindElement(By.LinkText("Adicionar")).Click();
            driver.FindElement(By.Id("nome")).SendKeys(conta);
            driver.FindElement(By.XPath("/html/body/div[2]/form/div[2]/button")).Click();
        }                  

        [Then(@"recebo a mensagem (.*)")]
        public void ThenReceboAMensagem(string mensagem)
        {
            element = driver.FindElement(By.XPath("/html/body/div[1]"));
            text = element.Text;
            Assert.AreEqual(mensagem, text);            
        }

       
    }    
}
