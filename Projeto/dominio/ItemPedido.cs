using System.Globalization;

namespace Projeto.dominio
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double PorcentagemDesconto { get; set; }
        public Pedido Pedido { get; set; } // Associação entre os objetos
        public Produto Produto { get; set; } // Associação entre os objetos

        public ItemPedido(int quantidade, double porcentagemDesconto, Pedido pedido, Produto produto)
        {
            Quantidade = quantidade;
            PorcentagemDesconto = porcentagemDesconto;
            Pedido = pedido;
            Produto = produto;
        }

        public double subTotal()
        {
            double desconto = Produto.Preco * PorcentagemDesconto / 100;
            return (Produto.Preco - desconto) * Quantidade;
        }

        public override string ToString()
        {
            return Produto.Descricao 
                + ", Preço: " 
                + Produto.Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Qte: " 
                + Quantidade 
                + ", Desconto: " 
                + PorcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture) 
                + "%, Subtotal: " 
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
