using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;
using UITests.Terminal;

public partial class Session
{
    private const string PackageName = "B158BDD8.LogetoTerminal_kaaqb1ec1n05t";

    public static string DefaultDirectory => Environment.GetEnvironmentVariable("UItests_Terminal_DefaultDirectory") ?? Constants.Directory.Default;
    public static string Enviroment => Environment.GetEnvironmentVariable("UItests_Terminal_Enviroment") ?? Constants.Environment.Staging;
    public static string Ip => Environment.GetEnvironmentVariable("UItests_Terminal_Ip") ?? "127.0.0.1";

    public static WindowsDriver<WindowsElement> Driver { get; set; }

    public static void InitLocalDrivers()
    {
        AppiumOptions appCapabilities = new AppiumOptions();
        appCapabilities.AddAdditionalCapability("app", PackageName + "!App");

        for (int i = 0; i < 5; i++)
        {
            try
            {
                Driver = new WindowsDriver<WindowsElement>(new Uri($"http://{Ip}:4723"), appCapabilities, TimeSpan.FromSeconds(120));

                if (Driver != null)
                {
                    break;
                }
            }
            catch (OpenQA.Selenium.WebDriverException)
            {
                Thread.Sleep(500);
            }
        }

        Assert.NotNull(Driver, "Failed to locate application");
        Driver.Manage().Window.Maximize();
    }
}
