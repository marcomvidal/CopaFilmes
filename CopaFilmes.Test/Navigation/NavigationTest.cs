using Xunit;
using CopaFilmes.Backend.Models;
using System.Collections.Generic;
using CopaFilmes.Backend.Repositories;
using CopaFilmes.Backend.Services;
using Moq;
using System.Net.Http;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CopaFilmes.Test.Navigation
{
    public class NavigationTest
    {
        private IWebDriver _driver;
        private const string _url = "http://localhost:4200/";
        
        public NavigationTest()
        {
            _driver = new ChromeDriver();
        }

        [Fact]
        public void EnterHomePageSeesFaseDeSelecao_Success()
        {
            _driver.Navigate().GoToUrl(_url);
            var heading = _driver.FindElement(By.XPath("//*[contains(text(), 'Fase de seleção')]"));

            Assert.Equal("Fase de seleção", heading.Text);
        }
    }
}