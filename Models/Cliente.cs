namespace ShopShop.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Genero { get; set; }
        public string Cidade { get; set; }

        public virtual ICollection<Compra>? Compras { get; set; }
    }
}
