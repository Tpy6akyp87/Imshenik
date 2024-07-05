using Models;
using Services;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

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
        Client client = new Client
        {
            FirstName = "Clle",
            LastName = "Bod",
            Age = 75,
            ClientId = "CliliR2D2",
            ClientEmail = "CliliC3PO"
        };
        Currency currency = new Currency
        {
            CurrencyCode = "USD",
            CurrencyName = "Dollar"
        };
        UpdEmployeeContract(employee);
        UpdCurrency(currency);


        BankService bankService = new BankService();
        Console.WriteLine(bankService.CalculateSalary());
        employee = bankService.FormClientToEmplyee(client);


        Stopwatch stopWatch = new Stopwatch();
        int zt = 513216;

        stopWatch.Start();
        object obj = zt;
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
                
        stopWatch.Start();
        zt = (int)obj;
        stopWatch.Stop();
        TimeSpan ts1 = stopWatch.Elapsed;
        string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
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