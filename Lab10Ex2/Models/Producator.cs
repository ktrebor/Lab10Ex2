namespace Lab10Ex2.Models
{
    public class Producator
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Tara { get; set; }

        public List<Autovehicul> Autovehicule { get;}

        public override string ToString() => $"{Nume} | {Tara}";
    }
}