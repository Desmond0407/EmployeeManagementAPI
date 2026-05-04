namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Employeeid { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string Department { get; set; }

        public string Address { get; set; }


        public Decimal Salary { get; set; }


        public string TPT { get; set; } // tranport using employee or not
    }
}
