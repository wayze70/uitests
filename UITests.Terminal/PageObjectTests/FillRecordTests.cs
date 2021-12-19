using NUnit.Framework;
using UITests.Terminal.PageObjects;


namespace UITests.Terminal
{
    class FillRecordTests : TestBase
    {
        private static string _descriptionText = "DescriptionAuto";
        private static string _contractItem = "ContractAuto";
        private static string _subcontractItem = "SubcontractAuto";
        private static bool _billatleSwitchState = true;
        private static string _listCustomFieldItem = "ListCustomFieldItem1";
        private static string _textCustomFieldText = "TextCustomFieldAuto";
        private static int _numberCustomFieldNumber = 132456789;
        private static double _decimalCustomFieldNumber = 1324.56789;
        private static bool _yesNoCustomFieldState = true;

        [SetUp]
        public void SetUp()
        {
            // Go to people list
            PageFactory.HomePage.ClickToEnterPin();

            // Select first person and enter pin
            PageFactory.SelectPersonPage.ClickToPerson();
            PageFactory.SelectPersonPage.EnterPin(1234);

            // Select activity
            PageFactory.TerminalTerminalPage.ClickToActivity();
        }

        [TearDown]
        public override void TearDown()
        {
            PageFactory.FillRecordOverviewPage.ClickToConfirmButton();

            PageFactory.ConfirmationPage.CheckIfFillAdditionalInfoButtonIsVisible();
            // Wait for home page
            PageFactory.HomePage.WaitForPage();
        }

        [Test, Order(1)]
        public static void FillRecordTest()
        {
            PageFactory.ConfirmationPage.ClickToFillAdditionalInfoButton();

            
            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Description, PageFactory.FillRecordDescriptionPage.GetPageTitle());
            PageFactory.FillRecordDescriptionPage.WriteAllInformationOnPage(_descriptionText);
            PageFactory.FillRecordDescriptionPage.ClickToNextPageButton();

            /*Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Contract, PageFactory.FillRecordContractPagePage.GetPageTitle());
            PageFactory.FillRecordContractPagePage.SelectContract(_contractItem);

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Subcontract, PageFactory.FillRecordSubcontractPage.GetPageTitle());
            PageFactory.FillRecordSubcontractPage.SelectSubcontract(_subcontractItem);
            */
            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.Billable, PageFactory.FillRecordBillablePage.GetPageTitle());
            PageFactory.FillRecordBillablePage.SetToggleSwitchState(_billatleSwitchState);
            PageFactory.FillRecordBillablePage.ClickToNextPageButton();

            /*Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.ListCustomField, PageFactory.FillRecordListCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordListCustomFieldPage.SelectListItem(_listCustomFieldItem);

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.TextCustomField, PageFactory.FillRecordTextCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordTextCustomFieldPage.WriteAllInformationOnPage(_textCustomFieldText);
            PageFactory.FillRecordDescriptionPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.NumberCustomField, PageFactory.FillRecordNumberCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordNumberCustomFieldPage.WriteAllInformationOnPage(_numberCustomFieldNumber);
            PageFactory.FillRecordNumberCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.DecimalCustomField, PageFactory.FillRecordDecimalCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordDecimalCustomFieldPage.WriteAllInformationOnPage(_decimalCustomFieldNumber);
            PageFactory.FillRecordDecimalCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordPageTitles.YesNoCustomField, PageFactory.FillRecordYesNoCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordYesNoCustomFieldPage.SetToggleSwitchState(_yesNoCustomFieldState);
            PageFactory.FillRecordYesNoCustomFieldPage.ClickToNextPageButton();
            */

            PageFactory.FillRecordOverviewPage.ClickToConfirmButton();

            PageFactory.ConfirmationPage.ClickToFillAdditionalInfoButton();
            PageFactory.FillRecordOverviewPage.CheckIfDeclineButtonIsVisible();
        }

        [Test, Order(2)]
        public static void OverviewTest()
        {
            FillRecordTest();

            // Overviews...
            Assert.AreEqual(_descriptionText, PageFactory.FillRecordOverviewPage.GetDescriptionValue());
            /*Assert.AreEqual(_contractItem, PageFactory.FillRecordOverviewPage.GetContractValue());
            Assert.AreEqual(_subcontractItem, PageFactory.FillRecordOverviewPage.GetSubcontractValue());*/
            Assert.AreEqual(_billatleSwitchState, PageFactory.FillRecordOverviewPage.GetBillableValue());
            /*Assert.AreEqual(_listCustomFieldItem, PageFactory.FillRecordOverviewPage.GetListCustomFieldValue());
            Assert.AreEqual(_textCustomFieldText, PageFactory.FillRecordOverviewPage.GetTextCustomFieldValue());
            Assert.AreEqual(_numberCustomFieldNumber, PageFactory.FillRecordOverviewPage.GetNumberCustomFieldValue());
            Assert.AreEqual(_decimalCustomFieldNumber, PageFactory.FillRecordOverviewPage.GetDecimalCustomFieldValue());
            Assert.AreEqual(_yesNoCustomFieldState, PageFactory.FillRecordOverviewPage.GetYesNoCustomFieldValue());*/
        }

        [Test, Order(3)]
        public static void ChangeOverviewTest()
        {
            FillRecordTest();

            // Change Description value 
            PageFactory.FillRecordOverviewPage.ClickToDescription();
            Assert.AreEqual(_descriptionText, PageFactory.FillRecordDescriptionPage.GetPageValue());
            PageFactory.FillRecordDescriptionPage.WriteAllInformationOnPage("descriptionAutoAfterEdit", true);
            PageFactory.FillRecordDescriptionPage.ClickToConfirmEditButton();
            Assert.AreEqual("descriptionAutoAfterEdit", PageFactory.FillRecordOverviewPage.GetDescriptionValue());

            // Change Billable value
            PageFactory.FillRecordOverviewPage.ClickToBillable();
            Assert.AreEqual(false, PageFactory.FillRecordOverviewPage.GetBillableValue());
        }

        [Test, Order(4)]
        public static void OverviewSettingsTest()
        {
            FillRecordTest();

            PageFactory.FillRecordOverviewPage.ClickToSettingsButton();
            PageFactory.FillRecordSettingsPage.CheckIfStartFillInOtherInformationAutomaticallyIsVisible();
            PageFactory.FillRecordSettingsPage.ClickToBackButton();
        }
    }
}
