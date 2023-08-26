namespace IKAPI.Dtos
{
    public class DtoCreateEmployee
    {
        public string Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public DateTime FirstStartDate { get; set; }
        public string CompanyID { get; set; }
    }
}
