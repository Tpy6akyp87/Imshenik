using Models;

namespace Services
{
    public class BankService
    {
        public int CalculateSalary()
        {
            Console.WriteLine("какая прибыль у банка?  ");
            int bankIncome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("какие расходы у банка?  ");
            int bankExpenses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сколько владельцев у банка?  ");
            int countOfOwners = Convert.ToInt32(Console.ReadLine());
            int salaryOwners = (bankIncome + bankExpenses)/countOfOwners;
            return salaryOwners;
        }
        public Employee FormClientToEmplyee(Client client)
        {            
            Employee employee = new Employee { FirstName = client.FirstName, LastName = client.LastName, Age = client.Age, Contract = "", EmployeeId = "", Salary = 0};
            return employee;
        }
    }
}