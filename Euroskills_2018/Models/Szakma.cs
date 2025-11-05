namespace Euroskills_2018.Models
{
    public class Szakma
    {
        public int Id { get; set; }
        public string Szakmanev { get; set; }
        public ICollection<Versenyzo> Versenyzok { get; set; }
    }
}
