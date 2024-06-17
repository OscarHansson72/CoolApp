namespace CoolWebsite.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                if (BirthDate.Month > DateTime.Now.Month && BirthDate.Day > DateTime.Now.Day) 
                    return DateTime.Now.Year - BirthDate.Year  - 1;
                return DateTime.Now.Year - BirthDate.Year;
            }
        }

    }
}
