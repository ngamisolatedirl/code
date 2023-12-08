namespace assignment2.Models
{
    public class Department
    {
    }
}
namespace assignment2.Models.Domain
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
