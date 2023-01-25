namespace Payroll
{
    class AccountHolderAdapter : IAccountHolder
    {
        private Employable _employable;

        public AccountHolderAdapter(Employable employable)
        {
            _employable = employable;
        }

        public string GetAccountDetails()
        {
            return $"Name: {_employable.GetFullName()}, Salary: {_employable.GetSalary()}";
        } 
    }
}

