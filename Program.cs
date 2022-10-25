namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateDailyWage calculateDailyWage = new CalculateDailyWage();
            calculateDailyWage.Calculate();
        }
    }
}