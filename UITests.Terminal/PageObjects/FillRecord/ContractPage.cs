namespace UITests.Terminal.PageObjects.FillRecord
{
    public class ContractPage
    {
        private CustomFindBy _contractList => new CustomFindBy(How.ClassName, AutomationLocators.FillRecord.ContractPage.ContractList);
    }
}
