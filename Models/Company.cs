namespace IKAPI.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
        // Burada Icollection türünden vermemizin nedeni her firmanın birden çok elemanı olacağı içindir.
    }
}

