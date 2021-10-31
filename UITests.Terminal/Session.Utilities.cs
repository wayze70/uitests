using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.IO;
using System.Threading;
using UITests.Terminal;

public partial class Session
{
    public static void SendKeys(WindowsElement element, string text)
    {
        element.Clear();
        element.SendKeys(text);
    }

    public static void TakeScreenshot(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentNullException(nameof(fileName));
        }

        Thread.Sleep(500);
        var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

        var screenshots = Path.Combine(DefaultDirectory, Constants.Directory.Screenshots);
        var errors = Path.Combine(screenshots, Constants.Directory.Errors);
        var dateTimeMark = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");

        Directory.CreateDirectory(errors);
        screenshot.SaveAsFile(Path.Combine(screenshots, fileName + " " + dateTimeMark + ".png"), ScreenshotImageFormat.Png);
    }
}