namespace Euroskills_2018.Models
{
    public class Orszag
    {
        public int Id { get; set; }
        public string Orszagnev { get; set; }
        public ICollection<Versenyzo> Versenyzok { get; set; }
    }
}
