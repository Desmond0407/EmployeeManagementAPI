namespace EmployeeManagementAPI.DTOs
{
    public class CreateEmployeeDTO
    {
        public class CreateEmployeeDto
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public int? Age { get; set; }
            public decimal? Salary { get; set; }
            public string Department { get; set; }
        }
    }
}
