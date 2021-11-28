using NUnit.Framework;
using UITests.Terminal.PageObjects;


namespace UITests.Terminal
{
    class FillRecordTests : TestBase
    {
        private static string _descriptionText = "DescriptionAuto";
        private static string _contractItem = "ContractAuto";
        // private static string _subcontractItem = "SubcontractAuto";
        private static bool _billatleSwitchState = true;
        /*private static string _listCustomFieldItem = "ListCustomFieldItem1";
        private static string _textCustomFieldText = "TextCustomFieldAuto";
        private static int _numberCustomFieldNumber = 132456789;
        private static double _decimalCustomFieldNumber = 1324.56789;
        private static bool _yesNoCustomFieldState = true;*/

        [Test]
        public static void FillRecordTest()
        {
            // Go to people list
            PageFactory.HomePage.ClickToEnterPin();

            // Select first person and enter pin
            PageFactory.SelectPersonPage.ClickToPerson();
            PageFactory.SelectPersonPage.EnterPin(1234);

            // Select activity
            PageFactory.TerminalTerminalPage.ClickToActivity();

            PageFactory.ConfirmationPage.ClickToFillAdditionalInfoButton();

            Assert.AreEqual(LocalizedStrings.FillRecordTitles.Description, PageFactory.FillRecordDescriptionPage.GetPageTitle());
            PageFactory.FillRecordDescriptionPage.WriteAllInformationOnPage(_descriptionText);
            PageFactory.FillRecordDescriptionPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordTitles.Contract, PageFactory.FillRecordContractPagePage.GetPageTitle());
            PageFactory.FillRecordContractPagePage.SelectContract(_contractItem);

            /*Assert.AreEqual(LocalizedStrings.FillRecordTitles.Subcontract, PageFactory.FillRecordSubcontractPage.GetPageTitle());
            PageFactory.FillRecordSubcontractPage.SelectSubcontract(_subcontractItem);
            */
            Assert.AreEqual(LocalizedStrings.FillRecordTitles.Billable, PageFactory.FillRecordBillablePage.GetPageTitle());
            PageFactory.FillRecordBillablePage.SetToggleSwitchState(_billatleSwitchState);
            PageFactory.FillRecordBillablePage.ClickToNextPageButton();

            /*Assert.AreEqual(LocalizedStrings.FillRecordTitles.ListCustomField, PageFactory.FillRecordListCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordListCustomFieldPage.SelectListItem(_listCustomFieldItem);

            Assert.AreEqual(LocalizedStrings.FillRecordTitles.TextCustomField, PageFactory.FillRecordTextCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordTextCustomFieldPage.WriteAllInformationOnPage(_textCustomFieldText);
            PageFactory.FillRecordDescriptionPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordTitles.NumberCustomField, PageFactory.FillRecordNumberCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordNumberCustomFieldPage.WriteAllInformationOnPage(_numberCustomFieldNumber);
            PageFactory.FillRecordNumberCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordTitles.DecimalCustomField, PageFactory.FillRecordDecimalCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordDecimalCustomFieldPage.WriteAllInformationOnPage(_decimalCustomFieldNumber);
            PageFactory.FillRecordDecimalCustomFieldPage.ClickToNextPageButton();

            Assert.AreEqual(LocalizedStrings.FillRecordTitles.YesNoCustomField, PageFactory.FillRecordYesNoCustomFieldPage.GetPageTitle());
            PageFactory.FillRecordYesNoCustomFieldPage.SetToggleSwitchState(_yesNoCustomFieldState);
            PageFactory.FillRecordYesNoCustomFieldPage.ClickToNextPageButton();
            */
            // Overviews...
            Assert.AreEqual(_descriptionText, PageFactory.FillRecordOverviewPage.CheckDescriptionValue());
            Assert.AreEqual(_contractItem, PageFactory.FillRecordOverviewPage.CheckContractValue());
            //Assert.AreEqual(_subcontractItem, PageFactory.FillRecordOverviewPage.CheckSubcontractValue());
            Assert.AreEqual(_billatleSwitchState, PageFactory.FillRecordOverviewPage.CheckBillableValue());
            /*Assert.AreEqual(_listCustomFieldItem, PageFactory.FillRecordOverviewPage.CheckListCustomFieldValue());
            Assert.AreEqual(_textCustomFieldText, PageFactory.FillRecordOverviewPage.CheckTextCustomFieldValue());
            Assert.AreEqual(_numberCustomFieldNumber, PageFactory.FillRecordOverviewPage.CheckNumberCustomFieldValue());
            Assert.AreEqual(_decimalCustomFieldNumber, PageFactory.FillRecordOverviewPage.CheckDecimalCustomFieldValue());
            Assert.AreEqual(_yesNoCustomFieldState, PageFactory.FillRecordOverviewPage.CheckYesNoCustomFieldValue());*/
            PageFactory.FillRecordOverviewPage.ClickToConfirmButton();

            PageFactory.ConfirmationPage.CheckIfFillAdditionalInfoButtonIsVisible();

            // Wait for home page
            PageFactory.HomePage.WaitForPage();
        }
    }
}
