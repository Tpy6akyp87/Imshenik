using Models;
using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            FirstName = "Yodda",
            LastName = "Bodda",
            Age = 775,
            EmployeeId = "R2D2",
            Contract = "C3PO",
            Salary = 5444
        };        
        Currency currency = new Currency
        {
            CurrencyCode = "USD",
            CurrencyName = "Dollar"
        };
        UpdEmployeeContract(employee);
        UpdCurrency(currency);
    }
    public static void UpdEmployeeContract(Employee employee)
    {
        employee.Contract = employee.Contract + "_upd";
        Console.WriteLine($"Contract for {employee.FirstName} {employee.LastName} updated");
        Console.WriteLine($"New contract is {employee.Contract}");
    }
    public static void UpdCurrency(Currency currency)
    {
        Console.WriteLine($"I will change {currency.CurrencyName} with code {currency.CurrencyCode}");
        currency.CurrencyCode = "RMNR";
        currency.CurrencyName = "Ruuble";
        Console.WriteLine($"New currency is {currency.CurrencyName} with code {currency.CurrencyCode}");
    }
}