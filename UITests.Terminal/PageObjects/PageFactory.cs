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
        public static Settings.PeoplePage SettingsPeoplePage => GetPage<Settings.PeoplePage>();
        public static SelectPersonPage SelectPersonPage => GetPage<SelectPersonPage>();
        public static HomePage HomePage => GetPage<HomePage>();
        public static Terminal.TerminalPage TerminalTerminalPage => GetPage<Terminal.TerminalPage>();
        public static Terminal.SummaryPage TerminalSummaryPage => GetPage<Terminal.SummaryPage>();
        public static ConfirmationPage ConfirmationPage => GetPage<ConfirmationPage>();
        public static FillRecord.DescriptionPage FillRecordDescriptionPage => GetPage<FillRecord.DescriptionPage>();
        public static FillRecord.ContractPage FillRecordContractPagePage => GetPage<FillRecord.ContractPage>();
        public static FillRecord.SubcontractPage FillRecordSubcontractPage => GetPage<FillRecord.SubcontractPage>();
    }
}
