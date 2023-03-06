namespace ShopShop.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }
        public double Total { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual ICollection<Lista>? Listas { get; set; }
    }
}
