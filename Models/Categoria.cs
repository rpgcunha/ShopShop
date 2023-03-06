﻿namespace ShopShop.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto>? Produtos { get; set; }
    }
}
