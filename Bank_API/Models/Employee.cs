namespace Bank_API.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public List<Branch> branches { get; set; }
    }
}
