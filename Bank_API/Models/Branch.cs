namespace Bank_API.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string Location { get; set; }
        public List<Employee> employees { get; set; }
    }
}
