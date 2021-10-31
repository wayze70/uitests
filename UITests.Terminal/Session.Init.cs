using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using UITests.Terminal;

[SetUpFixture]
public partial class Session
{
    private const string PackageName = "B158BDD8.LogetoTerminal_kaaqb1ec1n05t";
    private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

    public static string DefaultDirectory => Environment.GetEnvironmentVariable("UItests_Terminal_DefaultDirectory") ??  Constants.Directory.Default;
    public static string Enviroment => Environment.GetEnvironmentVariable("UItests_Terminal_Enviroment") ?? Constants.Enviroment.Staging;

    public static WindowsDriver<WindowsElement> Driver { get; set; }

    public static void InitLocalDrivers()
    {
        AppiumOptions appCapabilities = new AppiumOptions();
        appCapabilities.AddAdditionalCapability("app", PackageName + "!App");

        Driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities, TimeSpan.FromSeconds(120));
    }

    [OneTimeSetUp]
    public static void OneTimeSetUp()
    {
        InitLocalDrivers();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Driver.Quit();
    }
}