namespace UITests.Terminal.PageObjects
{
    public static class PageFactory
    {
        private static T GetPage<T>() where T : new()
        {
            return new T();            
        }

        public static Login.WelcomePage LoginWelcomePage => GetPage<Login.WelcomePage>();
        public static Login.AccountPage LoginAccountPage => GetPage<Login.AccountPage>();
        public static Login.NameAndLocationPage LoginNameAndLocationPage => GetPage<Login.NameAndLocationPage>();
        public static Login.LocationPopUp LocationPopUp => GetPage<Login.LocationPopUp>();
        public static Login.PasswordPage LoginPasswordPage => GetPage<Login.PasswordPage>();
        public static LoginToTerminalSettingsPage LoginToTerminalSettingsPage => GetPage<LoginToTerminalSettingsPage>();
        public static Settings.AccountPage SettingsAccountPage => GetPage<Settings.AccountPage>();
        public static Settings.YourAccount SettingsYourAccountPage => GetPage<Settings.YourAccount>();
        public static Settings.NameAndLocationPage SettingsNameAndLocationPage => GetPage<Settings.NameAndLocationPage>();
        public static Settings.BehaviorPage SettingsBehaviorPage => GetPage<Settings.BehaviorPage>();
        public static Settings.AppearancePage SettingsAppearancePage => GetPage<Settings.AppearancePage>();
        public static Settings.PeoplePage SettingsPeoplePage => GetPage<Settings.PeoplePage>();
        public static SelectPersonPage SelectPersonPage => GetPage<SelectPersonPage>();
        public static HomePage HomePage => GetPage<HomePage>();
        public static Terminal.TerminalPage TerminalTerminalPage => GetPage<Terminal.TerminalPage>();
        public static Terminal.SummaryPage TerminalSummaryPage => GetPage<Terminal.SummaryPage>();
        public static ConfirmationPage ConfirmationPage => GetPage<ConfirmationPage>();
        public static FillRecord.DescriptionPage FillRecordDescriptionPage => GetPage<FillRecord.DescriptionPage>();
        public static FillRecord.ContractPage FillRecordContractPagePage => GetPage<FillRecord.ContractPage>();
        public static FillRecord.SubcontractPage FillRecordSubcontractPage => GetPage<FillRecord.SubcontractPage>();
        public static FillRecord.BillablePage FillRecordBillablePage => GetPage<FillRecord.BillablePage>();
        public static FillRecord.ListCustomFieldPage FillRecordListCustomFieldPage => GetPage<FillRecord.ListCustomFieldPage>();
        public static FillRecord.TextCustomFieldPage FillRecordTextCustomFieldPage => GetPage<FillRecord.TextCustomFieldPage>();
        public static FillRecord.NumberCustomFieldPage FillRecordNumberCustomFieldPage => GetPage<FillRecord.NumberCustomFieldPage>();
        public static FillRecord.DecimalCustomFieldPage FillRecordDecimalCustomFieldPage => GetPage<FillRecord.DecimalCustomFieldPage>();
        public static FillRecord.YesNoCustomFieldPage FillRecordYesNoCustomFieldPage => GetPage<FillRecord.YesNoCustomFieldPage>();
        public static FillRecord.OverviewPage FillRecordOverviewPage => GetPage<FillRecord.OverviewPage>();
        public static FillRecord.SettingsPage FillRecordSettingsPage => GetPage<FillRecord.SettingsPage>();
    }
}
