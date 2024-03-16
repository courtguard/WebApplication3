namespace WebApplication3.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Vaccine> Vaccines { get; set;}


    }
}
