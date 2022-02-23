using NUnit.Framework;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    class SettingsTest : TestBase
    {
        private static string _terminalName = Constants.Terminal.Name;
        private static string _terminalPassword = Constants.Terminal.Password;
        private static string _terminalPin = Constants.Terminal.Pin;
        private static string _additionTitle = string.Empty;
        private static bool _useTerminalNameAsTitle = true;
        private static bool _loginPageAsDefult = false;
        private static bool _enableKeyboardEmulationReaders = false;
        private static bool _pinCheckBox = true;

        // Edited
        private static string _terminalNameEdited = Constants.Terminal.Name + "_Edited";
        private static string _additionTitleEdited = "AdditionTitle_Edited";
        private static bool _useTerminalNameAsTitleEdited = false;
        private static bool _loginPageAsDefultEdited = true;
        private static bool _enableKeyboardEmulationReadersEdited = true;

        [SetUp]
        public void SetUp()
        {
            PageFactory.HomePage.ClickToSettings();
            PageFactory.SettingsPages.LoginToTerminalSettingsPage.WriteAllInformationOnPage(_terminalPassword);
            PageFactory.SettingsPages.LoginToTerminalSettingsPage.ClickToContinueButton();
        }

        [TearDown]
        public override void TearDown()
        {
            base.TearDown();

            PageFactory.HomePage.WaitForPage();
        }

        [Test, Order(1)]
        public static void Account_Test()
        {
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.Account, PageFactory.SettingsPages.AccountPage.GetPageTitle());
            PageFactory.SettingsPages.AccountPage.ClickToLogoutButton();

            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.YourAccount, PageFactory.SettingsPages.YourAccountPage.GetPageTitle());
            PageFactory.SettingsPages.YourAccountPage.CheckInforationOnThisPage();
            PageFactory.SettingsPages.YourAccountPage.WritePassword(_terminalPassword);
            PageFactory.SettingsPages.YourAccountPage.ClickToContinueButton();
            PageFactory.HomePage.ClickToSettings();
            PageFactory.SettingsPages.LoginToTerminalSettingsPage.WriteAllInformationOnPage(_terminalPassword);
            PageFactory.SettingsPages.LoginToTerminalSettingsPage.ClickToContinueButton();

            PageFactory.SettingsPages.AccountPage.ClickToBackButton();
        }

        [Test, Order(2)]
        public static void NameAndLocation_Test()
        {
            // NameAndLocationPage
            PageFactory.SettingsPages.AccountPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.NameAndLocation);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.NameAndLocation, PageFactory.SettingsPages.NameAndLocationPage.GetPageTitle());
            Assert.AreEqual(_terminalName, PageFactory.SettingsPages.NameAndLocationPage.GetDeviceName());
            PageFactory.SettingsPages.NameAndLocationPage.SetDeviceName(_terminalNameEdited);
            PageFactory.SettingsPages.NameAndLocationPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Appearance);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.Appearance, PageFactory.SettingsPages.AppearancePage.GetPageTitle());
            Assert.AreEqual(_terminalNameEdited, PageFactory.SettingsPages.AppearancePage.GetMainTitle());
            PageFactory.SettingsPages.AccountPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.NameAndLocation);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.NameAndLocation, PageFactory.SettingsPages.NameAndLocationPage.GetPageTitle());
            PageFactory.SettingsPages.NameAndLocationPage.SetDeviceName(_terminalName);

            // PopupLocationPage
            PageFactory.SettingsPages.NameAndLocationPage.ClickToLocationClearButton();
            PageFactory.SettingsPages.NameAndLocationPage.ClickToLocationMapPopupButton();
            PageFactory.CommonPages.LocationPopupPage.SelectLocationFromMap();

            PageFactory.SettingsPages.NameAndLocationPage.ClickToBackButton();
        }

        [Test, Order(3)]
        public static void Behavior_Test()
        {
            PageFactory.SettingsPages.NameAndLocationPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Behavior);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.Behavior, PageFactory.SettingsPages.BehaviorPage.GetPageTitle());
            PageFactory.SettingsPages.BehaviorPage.SetSetLoginPageAsDefultCheckBoxState(_loginPageAsDefultEdited);
            PageFactory.SettingsPages.BehaviorPage.ClickToBackButton();
            PageFactory.HomePage.ClickToSettings();
            PageFactory.SelectPersonPage.WaitForPage();
            PageFactory.SelectPersonPage.ClickToBackButton();
            PageFactory.HomePage.ClickToSettings();
            PageFactory.SettingsPages.LoginToTerminalSettingsPage.WriteAllInformationOnPage(_terminalPassword);
            PageFactory.SettingsPages.LoginToTerminalSettingsPage.ClickToContinueButton();
            PageFactory.SettingsPages.AccountPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Behavior);
            PageFactory.SettingsPages.BehaviorPage.SetSetLoginPageAsDefultCheckBoxState(_loginPageAsDefult);

            PageFactory.SettingsPages.BehaviorPage.ClickToBackButton();
        }

        [Test, Order(4)]
        public static void Appearance_Test()
        {
            PageFactory.SettingsPages.BehaviorPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Appearance);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.Appearance, PageFactory.SettingsPages.AppearancePage.GetPageTitle());
            Assert.AreEqual(_terminalName, PageFactory.SettingsPages.AppearancePage.GetMainTitle());
            Assert.True(PageFactory.SettingsPages.AppearancePage.GetUseTerminalNameAsTitleCheckBoxState());
            PageFactory.SettingsPages.AppearancePage.SetUseTerminalNameAsTitleCheckBoxToState(_useTerminalNameAsTitleEdited);
            Assert.AreEqual(_terminalName, PageFactory.SettingsPages.AppearancePage.GetMainTitle());
            PageFactory.SettingsPages.AppearancePage.WriteAllInformationOnThisPage(_terminalNameEdited, _additionTitleEdited);
            PageFactory.SettingsPages.AppearancePage.ClickToBackButton();
            Assert.AreEqual(_terminalNameEdited + " ", PageFactory.HomePage.GetMainTitle());
            Assert.AreEqual(_additionTitleEdited, PageFactory.HomePage.GetAdditionTitle());
            PageFactory.HomePage.ClickToSettings();
            PageFactory.SettingsPages.LoginToTerminalSettingsPage.WriteAllInformationOnPage(_terminalPassword);
            PageFactory.SettingsPages.LoginToTerminalSettingsPage.ClickToContinueButton();
            PageFactory.SettingsPages.AccountPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Appearance);
            PageFactory.SettingsPages.AppearancePage.WriteAllInformationOnThisPage(_terminalName, _additionTitle);
            PageFactory.SettingsPages.AppearancePage.SetUseTerminalNameAsTitleCheckBoxToState(_useTerminalNameAsTitle);

            PageFactory.SettingsPages.AppearancePage.ClickToBackButton();
        }

        [Test, Order(5)]
        public static void General_Test()
        {
            PageFactory.SettingsPages.GeneralPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.General);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.General, PageFactory.SettingsPages.GeneralPage.GetPageTitle());
            PageFactory.SettingsPages.GeneralPage.SelectItemFromLanguageComboBox("English");
            Assert.IsTrue(PageFactory.SettingsPages.GeneralPage.IsWarningMessageVisible());
            PageFactory.SettingsPages.GeneralPage.SelectItemFromLanguageComboBox("Default");
            Assert.IsFalse(PageFactory.SettingsPages.GeneralPage.IsWarningMessageVisible());

            PageFactory.SettingsPages.GeneralPage.SetNewPassword(_terminalPassword, _terminalPassword);
            PageFactory.SettingsPages.GeneralPage.NewPasswordSuccessfulDialog();

            PageFactory.SettingsPages.GeneralPage.ClickToBackButton();
        }

        [Test, Order(6)]
        public static void People_Test()
        {
            PageFactory.SettingsPages.PeoplePage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.People);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.People, PageFactory.SettingsPages.PeoplePage.GetPageTitle());
            PageFactory.SettingsPages.PeoplePage.ClickToPerson();
            PageFactory.SettingsPages.PeoplePage.SetPinCheckBoxState(_pinCheckBox);
            PageFactory.SettingsPages.PeoplePage.SetPin(_terminalPin);
            Assert.AreEqual(_terminalPin, PageFactory.SettingsPages.PeoplePage.GetPin());

            PageFactory.SettingsPages.PeoplePage.ClickToBackButton();
        }

        [Test, Order(7)]
        public static void Indetificaiton_Test()
        {
            PageFactory.SettingsPages.IdentificationPage.ClickToSideMenuItem(LocalizedStrings.SettingsPageTitles.Identification);
            Assert.AreEqual(LocalizedStrings.SettingsPageTitles.Identification, PageFactory.SettingsPages.IdentificationPage.GetPageTitle());
            PageFactory.SettingsPages.IdentificationPage.SetEnableKeyboardEmulationReadersCheckBoxState(_enableKeyboardEmulationReadersEdited);
            Assert.IsTrue(PageFactory.SettingsPages.IdentificationPage.IsTestChipReaderButtonVisible());
            PageFactory.SettingsPages.IdentificationPage.SetEnableKeyboardEmulationReadersCheckBoxState(_enableKeyboardEmulationReaders);
            Assert.IsFalse(PageFactory.SettingsPages.IdentificationPage.IsTestChipReaderButtonVisible());

            PageFactory.SettingsPages.IdentificationPage.ClickToBackButton();
        }
    }
}
