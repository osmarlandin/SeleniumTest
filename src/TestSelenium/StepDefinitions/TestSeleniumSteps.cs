using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestSelenium.Support;
using OpenQA.Selenium.Support.UI;

namespace TestSelenium.StepDefinitions
{
    [Binding]
    public class TestSeleniumSteps
    {
        private ChromeDriver driver = Contexto.Driver;

        [Given(@"que eu estou na home")]
        public void DadoQueEuEstouNaHome()
        {
            var pagina = @"http://localhost:14809/Default.aspx";
            driver.Navigate().GoToUrl(pagina);
        }


        [When(@"eu seleciono o Valor (.*) no combo")]
        public void QuandoEuSelecionoOValorNoCombo(int p0)
        {
            
            var select = new SelectElement(driver.FindElement(By.TagName("select")));
            select.SelectByText("Valor 2");
        }

        [Then(@"o Valor (.*) fica selecionado")]
        public void EntaoOValorFicaSelecionado(int p0)
        {
            var select = new SelectElement(driver.FindElement(By.TagName("select")));
            select.SelectedOption.Text.Should().Be("Valor 2");
        }

        [When(@"eu clico no checkbox (.*)")]
        public void QuandoEuClicoNoCheckbox(int p0)
        {
            driver.FindElement(By.Id("CheckBox3")).Click();
        }

        [Then(@"o checkbox (.*) fica selecionado")]
        public void EntaoOCheckboxFicaSelecionado(int p0)
        {
            driver.FindElement(By.Id("CheckBox3")).Selected.Should().BeTrue();
        }

        [When(@"eu clico no radio (.*)")]
        public void QuandoEuClicoNoRadio(int p0)
        {
            driver.FindElement(By.Id("RadioButton1")).Click();
        }

        [Then(@"o radio (.*) fica selecionado")]
        public void EntaoORadioFicaSelecionado(int p0)
        {
            driver.FindElement(By.Id("RadioButton1")).Selected.Should().BeTrue();
        }

        [When(@"eu clico na Minha Li (.*)")]
        public void QuandoEuClicoNaMinhaLi(int p0)
        {
            driver.FindElement(By.Id("minhali1")).Click();
        }

        [Then(@"o textto Você clicou na Minha Li (.*) deve aparecer")]
        public void EntaoOTexttoVoceClicouNaMinhaLiDeveAparecer(int p0)
        {
            driver.PageSource.Contains("Você clicou na Minha Li 1").Should().BeTrue();
        }


    }
}
