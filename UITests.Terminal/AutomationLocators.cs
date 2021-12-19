namespace UITests.Terminal
{
    public static class AutomationLocators
    {
        public static class Login
        {
            public static class WelcomePage
            {
                public const string StartWizardButton = "StartWizardButton";
            }

            public static class AccountPage
            {
                public const string AccountNameTextBox = "AccountTextBox";
                public const string EmailTextBox = "LoginAccessKeyTextBox";
                public const string UserPassword = "UserPassword";
                public const string ContinueButton = "AccountContinueButton";
            }

            public static class NameAndLocationPage
            {
                public const string DeviceNameTextBox = "TerminalNameTextBox";
                public const string LocationAdressComboBox = "ComboBoxTextBox";
                public const string LocationClearButton = "ClearButton";
                public const string MapPopUpButton = "ExtraButton";
                public const string ContinueButton = "LocationContinueButton";
            }

            public static class LocationPopUp
            {
                public static string Map = "Map";
                public static string SelectButton = "OKButton";
            }

            public static class PasswordPage
            {
                public const string AdminPassword = "AdminPassword";
                public const string AdminPasswordCheck = "AdminPasswordCheck";
                public const string ContinueButton = "PasswordContinueButton";
            }
        }

        public static class HomePage
        {
            public const string TopLeftTitleTextBlock = "LeftTitleTextBlock";
            public const string TitleAdditionalTextBlock = "TitleAdditionalTextBlock";
            public const string TimeTextBlock = "TimeTextBlock";
            public const string MessageTextBlock = "MessageTextBlock";
            public const string GoToSettingButton = "GoToSettingButton";
            public const string SettingsButton = "SettingsButton";
            public const string EnterPin = "ManualLoginTextBlock";
        }

        public static class LoginToTerminalSettingsPage
        {
            public const string AdminPasswordTextBox = "AppPassword";
            public const string ContinueButton = "ConfirmButton";
        }

        public static class Settings
        {
            public static class SettingSideBar
            {
                public const string BackButton = "BackButton";

                public const string SideMenuItems = "ListViewItem";
                // No needed
                public const string AccountListItem = "Account";
                public const string LocationListItem = "Location";
                public const string BehaviorListItem = "Behavior";
                public const string AppearanceListItem = "Appearance";
                public const string GeneralListItem = "General";
                public const string PeopleListItem = "People";
                public const string IdentificationSettingListItem = "IdentificationSetting";
                //

                // TO DO
                public const string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][position()=1]";
            }

            public static class AccountPage
            {
                public const string LogoutButton = "LogoutButton";
            }

            public static class YourAccountPage
            {
                public const string AccountTextBox = "AccountTextBox";
                public const string EmailTextBox = "LoginAccessKeyTextBox";
                public const string UserPasswordTextBox = "UserPassword";
                public const string ContinueButton = "AccountContinueButton";
            }

            public static class NameAndLocationPage
            {
                public const string DeviceNameTextBox = "TerminalNameTextBox";
                public const string LocationAddressComboBox = "ComboBoxTextBox";
                public const string ClearButton = "ClearButton";
                public const string MapPopupButton = "ExtraButton";
            }

            public static class AppearancePage
            {
                public const string TitleMainTextBox = "TitleMainTextBox";
                public const string UseTerminalNameAsTitleCheckBox = "UseTerminalNameAsTitleCheckBox";
                public const string TitleAdditionalTextBox = "TitleAdditionalTextBox";
            }

            public static class PeoplePage
            {
                public const string PeopleList = "PeopleListView";
                public const string PinCheckBox = "UsePinCheckBox";
                public const string PinTextBox = "PINTextBox";
            }
        }

        public static class SelectPersonPage
        {
            public const string BackButton = "BackButton"; 

            public const string PeopleList = "ListViewItem";

            public const string NumZero = "Number0Button";
            public const string NumOne = "Number1Button";
            public const string NumTwo = "Number2Button";
            public const string NumThree = "Number3Button";
            public const string NumFour = "Number4Button";
            public const string NumFive = "Number5Button";
            public const string NumSix = "Number6Button";
            public const string NumSeven = "Number7Button";
            public const string NumEight = "Number8Button";
            public const string NumNine = "Number9Button";
            public const string ClearButton = "ClearButton";
            public const string BackspaceButton = "BackspaceButton";
        }

        public static class Terminal
        {
            public static class HamburgerMenu
            {
                public const string HamburgerMenuToggleButton = "HamburgerMenuToggleButton";

                public const string TerminalMenuItem = "TerminalMenuItem";
                public const string SummaryMenuItem = "SummaryMenuItem";
                public const string LogoutMenuItem = "LogoutMenuItem";
                public const string SettingsMenuItem = "SettingsMenuItem";
            }

            public static class TerminalPage
            {
                public const string ActivityList = "ActivityName";
            }

            public static class SummaryPage
            {
                public const string PageTitel = "LeftTitleTextBlock";
                public const string ThisMonthTotal = "MonthTotalTextBlock";
            }
        }

        public static class ConfirmationPage
        {
            public const string ActvitySelectedTextBlock = "ActvitySelectedTextBlock";
            public const string FillAdditionalInfoButton = "FillAdditionalInfoButton";
        }

        public static class FillRecord
        {
            public static class CommonItems
            {
                public const string CancelButton = "CancelButton";

                public const string PreviousPageButton = "PreviousEditItemButton";
                public const string NextPageButton = "NextEditItemButton";

                public const string ConfirmButton = "ConfirmButton";
                public const string DeclineButton = "BackButton";
            }

            public static class DescriptionPage
            {
                public const string PageTitel = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId16']";
                public const string TextBox = "AutomationId16TextBox";
            }

            public static class ContractPage
            {
                public const string PageTitel = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId17']";
                public const string ContractList = "ListBoxItem";
            }

            public static class SubcontractPage
            {
                public const string PageTitel = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId18']";
                public const string SubcontractList = "ListBoxItem";
            }

            public static class BillablePage
            {
                public static string PageTitel = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId19']";
                public static string ToggleSwitch = "AutomationId19ToggleSwitch";
            }

            public static class ListCustomFieldPage
            {
                public static string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId20']";
                public static string ListCustomList = "ListBoxItem";
            }

            public static class TextCustomFieldPage
            {
                public static string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId21']";
                public static string TextBox = "AutomationId21TextBox";
            }

            public static class NumberCustomFieldPage
            {
                public static string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId22']";
                public static string NumericTextBox = "AutomationId22NumericTextBox";
            }

            public static class DecimalCustomFieldPage
            {
                public static string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId23']";
                public static string DecimalTextBox = "AutomationId23NumericTextBox";
            }

            public static class YesNoCustomFieldPage
            {
                public static string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId24']";
                public static string ToggleSwitch = "AutomationId24ToggleSwitch";
            }

            public static class OverviewPage
            {
                public static string SettingsButton = "SettingsButton";
                public static string DeclineButton = "//Pane[@AutomationId='MainScrollViewer']/Button[@ClassName='Button'][position()=1]";
                public static string ConfirmButton = "//Pane[@AutomationId='MainScrollViewer']/Button[@ClassName='Button'][position()=2]";

                public static string UserSettings = "UserSettings";

                public static string DescriptionTextBox = "AutomationId16TextBox";
                public static string ContractComboBox = "AutomationId17TextBox";
                public static string SubcontractComboBox = "AutomationId18TextBox";
                public static string BillableToggleSwitch = "AutomationId19ToggleSwitch";
                public static string ListCustomFieldComboBox = "AutomationId20TextBox";
                public static string TextCustomFieldTextBox = "AutomationId21TextBox";
                public static string NumberCustomFieldTextBox = "AutomationId22NumericTextBox";
                public static string DecimalCustomFieldTextBox = "AutomationId23NumericTextBox";
                public static string YesNoToggleSwitch = "AutomationId24ToggleSwitch";
            }

            public static class OverviewSettingsPage
            {
                public static string BackButton = "BackButton";

                public static string StartFillInOtherInformationAutomatically = "FillInfoAutomaticallyCheckBox";
            }
        }
    }
}
