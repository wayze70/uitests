namespace UITests.Terminal
{
    public class AutomationLocators
    {
        public class CommonPages
        {
            public class LocationPopUpPage
            {
                public const string Map = "Map";
                public const string SelectButton = "OKButton";
            }
        }

        public class SetupPages
        {
            public class WelcomePage
            {
                public const string StartWizardButton = "StartWizardButton";
            }

            public class AccountPage
            {
                public const string AccountNameTextBox = "AccountTextBox";
                public const string EmailTextBox = "LoginAccessKeyTextBox";
                public const string UserPasswordTextBox = "UserPassword";
                public const string ContinueButton = "AccountContinueButton";
            }

            public class NameAndLocationPage
            {
                public const string DeviceNameTextBox = "TerminalNameTextBox";
                public const string LocationAdressComboBox = "ComboBoxTextBox";
                public const string LocationClearButton = "ClearButton";
                public const string MapPopUpButton = "ExtraButton";
                public const string ContinueButton = "LocationContinueButton";
            }

            public class PasswordPage
            {
                public const string AdminPasswordTextBox = "AdminPassword";
                public const string AdminPasswordCheckTextBox = "AdminPasswordCheck";
                public const string ContinueButton = "PasswordContinueButton";
            }
        }

        public class HomePage
        {
            public const string MainTitleTextBlock = "LeftTitleTextBlock";
            public const string AdditionalTitleTextBlock = "TitleAdditionalTextBlock";
            public const string TimeTextBlock = "TimeTextBlock";
            public const string MessageTextBlock = "MessageTextBlock";
            public const string GoToSettingButton = "GoToSettingButton";
            public const string SettingsButton = "SettingsButton";
            public const string EnterPinTextBlock = "ManualLoginTextBlock";
        }

        public class LoginToTerminalSettingsPage
        {
            public const string AdminPasswordTextBox = "AppPassword";
            public const string ContinueButton = "ConfirmButton";
        }

        public class SettingsPages
        {
            public class SettingsSideMenu
            {
                public const string BackButton = "BackButton";

                public const string AccountListItem = "Account";
                public const string LocationListItem = "Location";
                public const string BehaviorListItem = "Behavior";
                public const string AppearanceListItem = "Appearance";
                public const string GeneralListItem = "General";
                public const string PeopleListItem = "People";
                public const string IdentificationSettingListItem = "IdentificationSetting";

                public const string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][position()=1]";
            }

            public class AccountPage
            {
                public const string LogoutButton = "LogoutButton";
            }

            public class YourAccountPage
            {
                public const string AccountTextBox = "AccountTextBox";
                public const string EmailTextBox = "LoginAccessKeyTextBox";
                public const string UserPasswordTextBox = "UserPassword";
                public const string ContinueButton = "AccountContinueButton";
            }

            public class NameAndLocationPage
            {
                public const string DeviceNameTextBox = "TerminalNameTextBox";
                public const string ErrorMessageTextBlock = "TextBlock";
                public const string LocationAddressComboBox = "ComboBoxTextBox";
                public const string ClearButton = "ClearButton";
                public const string ExtraButton = "ExtraButton";
            }

            public class BehaviorPage
            {
                public const string SetLoginPageAsDefultCheckBox = "SetLoginPageAsDefultCheckBox";
                public const string TimeToSelectTextBox = "TimeToSelectTextBox";
                public const string TextBoxDeleteButton = "DeleteButton";
            }

            public class AppearancePage
            {
                public const string MainTitleTextBox = "TitleMainTextBox";
                public const string UseTerminalNameAsTitleCheckBox = "UseTerminalNameAsTitleCheckBox";
                public const string AdditionalTitleTextBox = "TitleAdditionalTextBox";
            }

            public class GeneralPage
            {
                public const string LanguageComboBox = "LanguageComboBox";
                public const string ComboBoxItems = "ComboBoxItem";
                public const string LightDismiss = "Light Dismiss";

                public const string ChangeWillTakeEffectOnApplicationRestart = "TextBlock";

                public const string TimeFormatComboBox = "TimeFormatComboBox";
                public const string NewPassword = "NewPassword";
                public const string NewPasswordCheck = "NewPasswordCheck";
                public const string ChangeAdministratorPassword = "Change administrator password";

                public const string OkButton = "PrimaryButton";
                public const string YesButton = "PrimaryButton";
                public const string NoButton = "SecondaryButton";
                public const string DialogMessageTextBlock = "DialogMessageTextBlock";
            }

            public class PeoplePage
            {
                public const string PeopleList = "Logeto.Client.Core.DataLayer.GLO_OSOBY";
                public const string PinCheckBox = "UsePinCheckBox";
                public const string PinTextBox = "PINTextBox";
            }

            public class IdentificationPage
            {
                public const string EnableKeyboardEmulationReadersCheckBox = "EnableHIDCardReadersCheckBox";
                public const string DropDownButton = "DropDownButton";
                public const string DropDownList = "ListViewItem";
                public const string TestChipReaderButton = "SmartCardTestButton";
            }
        }

        public class SelectPersonPage
        {
            public const string BackButton = "BackButton";

            public const string PeopleList = "ListViewItem";

            public const string ClearButton = "ClearButton";
            public const string BackspaceButton = "BackspaceButton";
        }

        public class TerminalPages
        {
            public class HamburgerMenu
            {
                public const string HamburgerMenuToggleButton = "HamburgerMenuToggleButton";

                public const string TerminalMenuItemButton = "TerminalMenuItem";
                public const string SummaryMenuItemButton = "SummaryMenuItem";
                public const string LogoutMenuItemButton = "LogoutMenuItem";
                public const string SettingsMenuItemButton = "SettingsMenuItem";
            }

            public class TerminalPage
            {
                public const string ActivityList = "ActivityName";
            }

            public class SummaryPage
            {
                public const string PageTitel = "LeftTitleTextBlock";
                public const string ThisMonthTotalTextBlock = "MonthTotalTextBlock";
            }
        }

        public class ConfirmationPage
        {
            public const string ActvitySelectedTextBlock = "ActvitySelectedTextBlock";
            public const string FillAdditionalInfoButton = "FillAdditionalInfoButton";
        }

        public class FillRecordPages
        {
            public class CommonItems
            {
                public const string CancelButton = "CancelButton";

                public const string PreviousPageButton = "PreviousEditItemButton";
                public const string NextPageButton = "NextEditItemButton";

                public const string ConfirmButton = "ConfirmButton";
                public const string DeclineButton = "BackButton";
            }

            public class DescriptionPage
            {
                public const string PageTitel = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId16']";
                public const string DescriptionTextBox = "AutomationId16TextBox";
            }

            public class ContractPage
            {
                public const string PageTitel = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId17']";
                public const string ContractList = "ListBoxItem";
            }

            public class SubcontractPage
            {
                public const string PageTitel = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId18']";
                public const string SubcontractList = "ListBoxItem";
            }

            public class BillablePage
            {
                public const string PageTitel = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId19']";
                public const string BillableToggleSwitch = "AutomationId19ToggleSwitch";
            }

            public class ListCustomFieldPage
            {
                public const string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId20']";
                public const string ListCustomList = "ListBoxItem";
            }

            public class TextCustomFieldPage
            {
                public const string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId21']";
                public const string TextCustomTextBox = "AutomationId21TextBox";
            }

            public class NumberCustomFieldPage
            {
                public const string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId22']";
                public const string NumberCustomTextBox = "AutomationId22NumericTextBox";
            }

            public class DecimalCustomFieldPage
            {
                public const string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId23']";
                public const string DecimalCustomTextBox = "AutomationId23NumericTextBox";
            }

            public class YesNoCustomFieldPage
            {
                public const string PageTitle = "//Pane[@AutomationId='MainScrollViewer']/Text[@ClassName='TextBlock'][@AutomationId='AutomationId24']";
                public const string YesNoCustomToggleSwitch = "AutomationId24ToggleSwitch";
            }

            public class OverviewPage
            {
                public const string SettingsButton = "SettingsButton";
                public const string DeclineButton = "//Pane[@AutomationId='MainScrollViewer']/Button[@ClassName='Button'][position()=1]";
                public const string ConfirmButton = "//Pane[@AutomationId='MainScrollViewer']/Button[@ClassName='Button'][position()=2]";

                public const string DescriptionTextBox = "AutomationId16TextBox";
                public const string ContractComboBox = "AutomationId17TextBox";
                public const string SubcontractComboBox = "AutomationId18TextBox";
                public const string BillableToggleSwitch = "AutomationId19ToggleSwitch";
                public const string ListCustomFieldComboBox = "AutomationId20TextBox";
                public const string TextCustomFieldTextBox = "AutomationId21TextBox";
                public const string NumberCustomFieldTextBox = "AutomationId22NumericTextBox";
                public const string DecimalCustomFieldTextBox = "AutomationId23NumericTextBox";
                public const string YesNoCustomFieldToggleSwitch = "AutomationId24ToggleSwitch";
            }

            public class OverviewSettingsPage
            {
                public const string BackButton = "BackButton";

                public const string StartFillInOtherInformationAutomaticallyCheckBox = "FillInfoAutomaticallyCheckBox";
            }
        }
    }
}
