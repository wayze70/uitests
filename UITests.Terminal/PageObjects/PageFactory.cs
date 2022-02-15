namespace UITests.Terminal.PageObjects
{
    public static class PageFactory
    {
        private static T GetPage<T>() where T : new()
        {
            return new T();
        }

        public static HomePage HomePage => GetPage<HomePage>();
        public static SelectPersonPage SelectPersonPage => GetPage<SelectPersonPage>();

        public static class CommonPages
        {
            public static PageObjects.CommonPages.LocationPopupPage LocationPopupPage => GetPage<PageObjects.CommonPages.LocationPopupPage>();
        }

        public static class SetupPages
        {
            public static PageObjects.SetupPages.WelcomePage WelcomePage => GetPage<PageObjects.SetupPages.WelcomePage>();
            public static PageObjects.SetupPages.AccountPage AccountPage => GetPage<PageObjects.SetupPages.AccountPage>();
            public static PageObjects.SetupPages.NameAndLocationPage NameAndLocationPage => GetPage<PageObjects.SetupPages.NameAndLocationPage>();
            public static PageObjects.SetupPages.PasswordPage PasswordPage => GetPage<PageObjects.SetupPages.PasswordPage>();
        }

        public static class SettingsPages
        {
            public static PageObjects.SettingsPages.LoginToTerminalSettingsPage LoginToTerminalSettingsPage => GetPage<PageObjects.SettingsPages.LoginToTerminalSettingsPage>();
            public static PageObjects.SettingsPages.AccountPage AccountPage => GetPage<PageObjects.SettingsPages.AccountPage>();
            public static PageObjects.SettingsPages.YourAccount YourAccountPage => GetPage<PageObjects.SettingsPages.YourAccount>();
            public static PageObjects.SettingsPages.NameAndLocationPage NameAndLocationPage => GetPage<PageObjects.SettingsPages.NameAndLocationPage>();
            public static PageObjects.SettingsPages.BehaviorPage BehaviorPage => GetPage<PageObjects.SettingsPages.BehaviorPage>();
            public static PageObjects.SettingsPages.AppearancePage AppearancePage => GetPage<PageObjects.SettingsPages.AppearancePage>();
            public static PageObjects.SettingsPages.GeneralPage GeneralPage => GetPage<PageObjects.SettingsPages.GeneralPage>();
            public static PageObjects.SettingsPages.PeoplePage PeoplePage => GetPage<PageObjects.SettingsPages.PeoplePage>();
            public static PageObjects.SettingsPages.IdentificationPage IdentificationPage => GetPage<PageObjects.SettingsPages.IdentificationPage>();
        }

        public static class TerminalPages
        {
            public static PageObjects.TerminalPages.TerminalPage TerminalPage => GetPage<PageObjects.TerminalPages.TerminalPage>();
            public static PageObjects.TerminalPages.SummaryPage SummaryPage => GetPage<PageObjects.TerminalPages.SummaryPage>();
        }

        public static class FillRecordPages
        {
            public static PageObjects.FillRecordPages.ConfirmationPage ConfirmationPage => GetPage<PageObjects.FillRecordPages.ConfirmationPage>();
            public static PageObjects.FillRecordPages.DescriptionPage DescriptionPage => GetPage<PageObjects.FillRecordPages.DescriptionPage>();
            public static PageObjects.FillRecordPages.ContractPage ContractPagePage => GetPage<PageObjects.FillRecordPages.ContractPage>();
            public static PageObjects.FillRecordPages.SubcontractPage SubcontractPage => GetPage<PageObjects.FillRecordPages.SubcontractPage>();
            public static PageObjects.FillRecordPages.BillablePage BillablePage => GetPage<PageObjects.FillRecordPages.BillablePage>();
            public static PageObjects.FillRecordPages.ListCustomFieldPage ListCustomFieldPage => GetPage<PageObjects.FillRecordPages.ListCustomFieldPage>();
            public static PageObjects.FillRecordPages.TextCustomFieldPage TextCustomFieldPage => GetPage<PageObjects.FillRecordPages.TextCustomFieldPage>();
            public static PageObjects.FillRecordPages.NumberCustomFieldPage NumberCustomFieldPage => GetPage<PageObjects.FillRecordPages.NumberCustomFieldPage>();
            public static PageObjects.FillRecordPages.DecimalCustomFieldPage DecimalCustomFieldPage => GetPage<PageObjects.FillRecordPages.DecimalCustomFieldPage>();
            public static PageObjects.FillRecordPages.YesNoCustomFieldPage YesNoCustomFieldPage => GetPage<PageObjects.FillRecordPages.YesNoCustomFieldPage>();
            public static PageObjects.FillRecordPages.OverviewPage OverviewPage => GetPage<PageObjects.FillRecordPages.OverviewPage>();
            public static PageObjects.FillRecordPages.SettingsPage SettingsPage => GetPage<PageObjects.FillRecordPages.SettingsPage>();
        }
    }
}
