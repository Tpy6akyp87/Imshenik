namespace Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public class Employee : Person 
    {
        public string EmployeeId { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
    public class Client : Person
    {
        public string ClientId { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
    }
    public struct Currency
    {
        public string CurrencyCode { get; set;}
        public string CurrencyName { get; set;}
    }
}