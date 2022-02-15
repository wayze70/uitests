using NUnit.Framework;
using UITests.Terminal.PageObjects;

namespace UITests.Terminal
{
    class FillRecordTests : TestBase
    {
        // New record
        private static string _descriptionText = "DescriptionAuto";
        private static string _contractItem = "DGC_0001 - " + "ContractAuto_0001";
        private static string _subcontractItem = "DGS_0001 - " + "SubcontractAuto_0001";
        private static bool _billatleSwitchState = true;
        private static string _listCustomFieldItem = "0001 - " + "ListCustomFieldItem_0001";
        private static string _textCustomFieldText = "TextCustomFieldAuto";
        private static int _numberCustomFieldNumber = 132456789;
        private static double _decimalCustomFieldNumber = 1324.56789;
        private static bool _yesNoCustomFieldState = true;

        // Edit record
        private static string _descriptionTextEdited = "DescriptionAuto_Edited";
        private static string _contractItemEdited = "DGC_0002 - " + "ContractAuto_0002";
        private static string _subcontractItemEdited = "DGS_0002 - " + "SubcontractAuto_0002";
        private static bool _billatleSwitchStateEdited = false;
        private static string _listCustomFieldItemEdited = "0002 - " + "ListCustomFieldItem_0002";
        private static string _textCustomFieldTextEdited = "TextCustomFieldAuto_Edited";
        private static int _numberCustomFieldNumberEdited = 987654321;
        private static double _decimalCustomFieldNumberEdited = 9876.54321;
        private static bool _yesNoCustomFieldStateEdited = false;

        private static bool _contractIsSelected;

        [SetUp]
        public void SetUp()
        {
            // Go to people list
            PageFactory.HomePage.ClickToEnterPin();

            // Select first person and enter pin
            PageFactory.SelectPersonPage.ClickToPerson();
            PageFactory.SelectPersonPage.EnterPin(1234);

            // Select activity
            PageFactory.TerminalPages.TerminalPage.ClickToActivity();
        }

        [TearDown]
        public override void TearDown()
        {
            base.TearDown();

            // Wait for home page
            PageFactory.HomePage.WaitForPage();
        }

        [Test, Order(1)]
        public static void AddRecord_Test()
        {
            PageFactory.FillRecordPages.ConfirmationPage.ClickToFillAdditionalInfoButton();

            FillRecord();

            Assert.AreEqual(_descriptionText, PageFactory.FillRecordPages.OverviewPage.GetDescriptionValue());
            Assert.AreEqual(_contractItem, PageFactory.FillRecordPages.OverviewPage.GetContractValue());
            Assert.AreEqual(_subcontractItem, PageFactory.FillRecordPages.OverviewPage.GetSubcontractValue());
            Assert.AreEqual(_billatleSwitchState, PageFactory.FillRecordPages.OverviewPage.GetBillableValue());
            Assert.AreEqual(_listCustomFieldItem, PageFactory.FillRecordPages.OverviewPage.GetListCustomFieldValue());
            Assert.AreEqual(_textCustomFieldText, PageFactory.FillRecordPages.OverviewPage.GetTextCustomFieldValue());

            // Generátor databází zatím nepodporuje vlastní pole typu: Number, Decimal, Yes/No

            /*Assert.AreEqual(_numberCustomFieldNumber, PageFactory.FillRecordPages.OverviewPage.GetNumberCustomFieldValue());
            Assert.AreEqual(_decimalCustomFieldNumber, PageFactory.FillRecordPages.OverviewPage.GetDecimalCustomFieldValue());
            Assert.AreEqual(_yesNoCustomFieldState, PageFactory.FillRecordPages.OverviewPage.GetYesNoCustomFieldValue());*/

            PageFactory.FillRecordPages.OverviewPage.ClickToConfirmButton();
        }

        [Test, Order(2)]
        public static void EditRecord_Test()
        {
            PageFactory.FillRecordPages.ConfirmationPage.ClickToFillAdditionalInfoButton();

            FillRecord();

            // Description 
            PageFactory.FillRecordPages.OverviewPage.ClickToDescription();
            Assert.AreEqual(_descriptionText, PageFactory.FillRecordPages.DescriptionPage.GetPageValue());
            PageFactory.FillRecordPages.DescriptionPage.WriteAllInformationOnPage(_descriptionTextEdited);
            PageFactory.FillRecordPages.DescriptionPage.ClickToConfirmEditButton();
            Assert.AreEqual(_descriptionTextEdited, PageFactory.FillRecordPages.OverviewPage.GetDescriptionValue());

            // Contract and subcontract
            PageFactory.FillRecordPages.OverviewPage.ClickToContract();
            PageFactory.FillRecordPages.ContractPagePage.SelectContract(_contractItemEdited);
            PageFactory.FillRecordPages.SubcontractPage.SelectSubcontract(_subcontractItemEdited);
            Assert.AreEqual(_contractItemEdited, PageFactory.FillRecordPages.OverviewPage.GetContractValue());
            Assert.AreEqual(_subcontractItemEdited, PageFactory.FillRecordPages.OverviewPage.GetSubcontractValue());

            // Billable
            // The changed contract has changed the value of the billable
            Assert.AreEqual(false, PageFactory.FillRecordPages.OverviewPage.GetBillableValue());
            PageFactory.FillRecordPages.OverviewPage.ClickToBillable();
            Assert.AreEqual(true, PageFactory.FillRecordPages.OverviewPage.GetBillableValue());

            // List custom field
            PageFactory.FillRecordPages.OverviewPage.ClickToListCustomField();
            PageFactory.FillRecordPages.ListCustomFieldPage.SelectListCustomFieldItem(_listCustomFieldItemEdited);
            Assert.AreEqual(_listCustomFieldItemEdited, PageFactory.FillRecordPages.OverviewPage.GetListCustomFieldValue());

            // Text custom field
            PageFactory.FillRecordPages.OverviewPage.ClickToTextCustomField();
            PageFactory.FillRecordPages.TextCustomFieldPage.WriteAllInformationOnPage(_textCustomFieldTextEdited);
            PageFactory.FillRecordPages.TextCustomFieldPage.ClickToConfirmEditButton();
            Assert.AreEqual(_textCustomFieldTextEdited, PageFactory.FillRecordPages.OverviewPage.GetTextCustomFieldValue());

            // Generátor databází zatím nepodporuje vlastní pole typu: Number, Decimal, Yes/No

            // Number custom field
            /*PageFactory.FillRecordPages.OverviewPage.ClickToNumberCustomField();
            PageFactory.FillRecordPages.NumberCustomFieldPage.WriteAllInformationOnPage(_numberCustomFieldNumberEdited);
            PageFactory.FillRecordPages.NumberCustomFieldPage.ClickToConfirmEditButton();
            Assert.AreEqual(_numberCustomFieldNumberEdited, PageFactory.FillRecordPages.OverviewPage.GetNumberCustomFieldValue());

            // Decimal custom field
            PageFactory.FillRecordPages.OverviewPage.ClickToDecimalCustomField();
            PageFactory.FillRecordPages.DecimalCustomFieldPage.WriteAllInformationOnPage(_decimalCustomFieldNumberEdited);
            PageFactory.FillRecordPages.DecimalCustomFieldPage.ClickToConfirmEditButton();
            Assert.AreEqual(_decimalCustomFieldNumberEdited, PageFactory.FillRecordPages.OverviewPage.GetDecimalCustomFieldValue());

            // Yes no custom field
            PageFactory.FillRecordPages.OverviewPage.ClickToYesNoCustomField();
            Assert.AreEqual(_yesNoCustomFieldStateEdited, PageFactory.FillRecordPages.OverviewPage.GetYesNoCustomFieldValue());*/

            PageFactory.FillRecordPages.OverviewPage.ClickToConfirmButton();
        }

        [Test, Order(3)]
        public static void Settings_Test()
        {
            PageFactory.FillRecordPages.ConfirmationPage.ClickToFillAdditionalInfoButton();

            SkipFillRecord();

            PageFactory.FillRecordPages.OverviewPage.ClickToSettingsButton();
            PageFactory.FillRecordPages.SettingsPage.CheckIfStartFillInOtherInformationAutomaticallyIsVisible();
            PageFactory.FillRecordPages.SettingsPage.ClickToBackButton();

            PageFactory.FillRecordPages.OverviewPage.ClickToConfirmButton();
        }

        private static void FillRecord()
        {
            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Description, PageFactory.FillRecordPages.DescriptionPage.GetPageTitle());
            PageFactory.FillRecordPages.DescriptionPage.WriteAllInformationOnPage(_descriptionText);
            PageFactory.FillRecordPages.DescriptionPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Contract, PageFactory.FillRecordPages.ContractPagePage.GetPageTitle());
            PageFactory.FillRecordPages.ContractPagePage.SelectContract(_contractItem);

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Subcontract, PageFactory.FillRecordPages.SubcontractPage.GetPageTitle());
            PageFactory.FillRecordPages.SubcontractPage.SelectSubcontract(_subcontractItem);

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Billable, PageFactory.FillRecordPages.BillablePage.GetPageTitle());
            PageFactory.FillRecordPages.BillablePage.SetToggleSwitchState(_billatleSwitchState);
            PageFactory.FillRecordPages.BillablePage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.ListCustomField, PageFactory.FillRecordPages.ListCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.ListCustomFieldPage.SelectListCustomFieldItem(_listCustomFieldItem);
            
            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.TextCustomField, PageFactory.FillRecordPages.TextCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.TextCustomFieldPage.WriteAllInformationOnPage(_textCustomFieldText);
            PageFactory.FillRecordPages.TextCustomFieldPage.ClickToNextPageButton();
            

            // Generátor databází zatím nepodporuje vlastní pole typu: Number, Decimal, Yes/No

            /*Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.NumberCustomField, PageFactory.FillRecordPages.NumberCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.NumberCustomFieldPage.WriteAllInformationOnPage(_numberCustomFieldNumber);
            PageFactory.FillRecordPages.NumberCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.DecimalCustomField, PageFactory.FillRecordPages.DecimalCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.DecimalCustomFieldPage.WriteAllInformationOnPage(_decimalCustomFieldNumber);
            PageFactory.FillRecordPages.DecimalCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.YesNoCustomField, PageFactory.FillRecordPages.YesNoCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.YesNoCustomFieldPage.SetToggleSwitchState(_yesNoCustomFieldState);
            PageFactory.FillRecordPages.YesNoCustomFieldPage.ClickToNextPageButton();*/
        }

        private static void SkipFillRecord()
        {
            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Description, PageFactory.FillRecordPages.DescriptionPage.GetPageTitle());
            PageFactory.FillRecordPages.DescriptionPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Contract, PageFactory.FillRecordPages.ContractPagePage.GetPageTitle());
            _contractIsSelected = PageFactory.FillRecordPages.ContractPagePage.IsContractSelected();
            PageFactory.FillRecordPages.ContractPagePage.ClickToNextPageButton();

            if (_contractIsSelected)
            {
                Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Subcontract, PageFactory.FillRecordPages.SubcontractPage.GetPageTitle());
                PageFactory.FillRecordPages.SubcontractPage.ClickToNextPageButton();
            }

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Billable, PageFactory.FillRecordPages.BillablePage.GetPageTitle());
            PageFactory.FillRecordPages.BillablePage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.ListCustomField, PageFactory.FillRecordPages.ListCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.ListCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.TextCustomField, PageFactory.FillRecordPages.TextCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.TextCustomFieldPage.ClickToNextPageButton();

            // Generátor databází zatím nepodporuje vlastní pole typu: Number, Decimal, Yes/No

            /*Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.NumberCustomField, PageFactory.FillRecordPages.NumberCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.NumberCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.DecimalCustomField, PageFactory.FillRecordPages.DecimalCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.DecimalCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.YesNoCustomField, PageFactory.FillRecordPages.YesNoCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordPages.YesNoCustomFieldPage.ClickToNextPageButton();*/
        }
    }
}
