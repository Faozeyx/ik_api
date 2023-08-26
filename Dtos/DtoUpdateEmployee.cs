namespace IKAPI.Dtos
{
    public class DtoUpdateEmployee
    {
        //Update kısmında Id dışındakiler nullable olmalı yani boş bırakılabilir.
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public DateTime? FirstStartDate { get; set; }
        public string? CompanyID { get; set; }
    }
}
