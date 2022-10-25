namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateWageByHrs calculateWageByHrs = new CalculateWageByHrs();
            calculateWageByHrs.Calculate();
            
        }
    }
}