using NUnit.Framework;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    class SettingsTest : TestBase
    {
        [Test, Order(2)]
        public static void GoToSettings()
        {
            PageFactory.HomePage.ClickToSettings();
            PageFactory.LoginToTerminalSettingsPage.WriteAllInformationOnPage("123456");
            PageFactory.LoginToTerminalSettingsPage.ClickToContinueButton();

            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.Account, PageFactory.SettingsAccountPage.GetPageTitle());
            PageFactory.SettingsAccountPage.ClickToLogoutButton();

            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.YourAccount, PageFactory.SettingsYourAccountPage.GetPageTitle());
            PageFactory.SettingsYourAccountPage.CheckInforationOnThisPage();
            PageFactory.SettingsYourAccountPage.WritePassword(123456);
            PageFactory.SettingsYourAccountPage.ClickToContinueButton();

            PageFactory.HomePage.ClickToSettings();
            PageFactory.LoginToTerminalSettingsPage.WriteAllInformationOnPage("123456");
            PageFactory.LoginToTerminalSettingsPage.ClickToContinueButton();
            PageFactory.SettingsAccountPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.NameAndLocation);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.NameAndLocation, PageFactory.SettingsNameAndLocationPage.GetPageTitle());
            Assert.AreEqual("HW-Terminal", PageFactory.SettingsNameAndLocationPage.GetDeviceName());
            // POP UP MAP

            PageFactory.SettingsNameAndLocationPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Behavior);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.Behavior, PageFactory.SettingsBehaviorPage.GetPageTitle());
            // DO SOMETHING HERE

            PageFactory.SettingsBehaviorPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Appearance);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.Appearance, PageFactory.SettingsAppearancePage.GetPageTitle());
            Assert.AreEqual("HW-Terminal", PageFactory.SettingsAppearancePage.GetMainTitle());
            Assert.True(PageFactory.SettingsAppearancePage.GetUseTerminalNameAsTitleCheckBoxState());
            PageFactory.SettingsAppearancePage.SetUseTerminalNameAsTitleCheckBoxToState(false);
            Assert.AreEqual("HW-Terminal", PageFactory.SettingsAppearancePage.GetMainTitle());
            PageFactory.SettingsAppearancePage.WriteAllInformationOnThisPage("HW-Terminal_Edited", "AdditionTitle");
            PageFactory.SettingsAppearancePage.ClickToBackButton();
            Assert.AreEqual("HW-Terminal_Edited ", PageFactory.HomePage.GetMainTitle());
            Assert.AreEqual("AdditionTitle", PageFactory.HomePage.GetAdditionTitle());
            PageFactory.HomePage.ClickToSettings();
            PageFactory.LoginToTerminalSettingsPage.WriteAllInformationOnPage("123456");
            PageFactory.LoginToTerminalSettingsPage.ClickToContinueButton();
            PageFactory.SettingsAccountPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Appearance);
            PageFactory.SettingsAppearancePage.WriteAllInformationOnThisPage("HW-Terminal", "AdditionTitle", true);
            PageFactory.SettingsAppearancePage.SetUseTerminalNameAsTitleCheckBoxToState(true);
            Assert.True(PageFactory.SettingsAppearancePage.GetUseTerminalNameAsTitleCheckBoxState());
        }

        [Test, Order(1)]
        public static void SetSettingsToDefault()
        {
            PageFactory.HomePage.ClickToSettings();
            PageFactory.LoginToTerminalSettingsPage.WriteAllInformationOnPage("123456");
            PageFactory.LoginToTerminalSettingsPage.ClickToContinueButton();

            PageFactory.SettingsAccountPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Appearance);
            PageFactory.SettingsAppearancePage.SetUseTerminalNameAsTitleCheckBoxToState(false);
            PageFactory.SettingsAppearancePage.WriteAllInformationOnThisPage("HW-Terminal", string.Empty, true);
            PageFactory.SettingsAppearancePage.SetUseTerminalNameAsTitleCheckBoxToState(true);

            PageFactory.SettingsAppearancePage.ClickToBackButton();
            PageFactory.HomePage.WaitForPage();
        }
    }
}
