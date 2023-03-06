namespace ShopShop.Models
{
    public class Lista
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string Local { get; set; }

        public virtual Compra? Compra { get; set; }
        public virtual Produto? Produto { get; set; }
    }
}
