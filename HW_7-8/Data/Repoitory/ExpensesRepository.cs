﻿namespace HW_7_8.Data.Repoitory
{
    public class ExpensesRepository:IExpensesRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ExpensesRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Expenses> GetAllExpenses()
        {
            var categories = dbContext.expenses.ToList();
            return categories;
        }

        public Expenses GetExpenseById(int id)
        {
            var expense = dbContext.expenses.Find(id);

            return expense;
        }

        public void Add(Expenses expenses)
        {
            dbContext.expenses.Add(expenses);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dbContext.expenses.Remove(GetExpenseById(id));
            dbContext.SaveChanges();
        }

        public void Update(Expenses expenses)
        {
            dbContext.expenses.Update(expenses);
            dbContext.SaveChanges();
        }
    }
}
