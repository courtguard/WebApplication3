namespace WebApplication3.Models
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
