namespace ShopShop.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public double? PrecoCont { get; set; }
        public double? PrecoPD { get; set; }
        public double? PrecoMerc { get; set; }


        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Lista>? Listas { get; set; }

    }
}
