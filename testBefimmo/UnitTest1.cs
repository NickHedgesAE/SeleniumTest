﻿
// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

[TestFixture]
public class BuildingchangeTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void buildingchange()
    {
        driver.Navigate().GoToUrl("https://www.standaard.be/");
        driver.Manage().Window.Size = new System.Drawing.Size(1652, 1020);
        driver.FindElement(By.Id("didomi-notice-agree-button")).Click();
        driver.FindElement(By.LinkText("Buitenland")).Click();
        driver.FindElement(By.LinkText("Corona")).Click();
        driver.FindElement(By.CssSelector(".searchbox-toggle")).Click();
        driver.FindElement(By.Name("keyword")).Click();
        driver.FindElement(By.Name("keyword")).SendKeys("nieuwnieuws");
        driver.FindElement(By.Name("keyword")).SendKeys(Keys.Enter);
    }
}