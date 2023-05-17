namespace HW_7_8.Data.Repoitory
{
    public interface IExpensesRepository
    {
        IEnumerable<Expenses> GetAllExpenses();
        Expenses GetExpenseById(int id);
        public void Add(Expenses expenses);
        public void Update(Expenses expenses);
        public void Delete(int id);
    }
}
