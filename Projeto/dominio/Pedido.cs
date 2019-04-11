using System;
using System.Globalization;
using System.Collections.Generic;

namespace Projeto.dominio
{
    class Pedido
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public List<ItemPedido> itens { get; set; } 

        public Pedido(int codigo, int dia, int mes, int ano)
        {
            Codigo = codigo;
            Data = new DateTime(ano, mes, dia);
            itens = new List<ItemPedido>();
        }

        public double valorTotal()
        {
            double soma = 0.0;
            for(int i = 0; i < itens.Count; i++)
            {
                soma = soma + itens[i].subTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            string s = "Pedido: " + Codigo
                + ", data: " + Data.Day + "/" + Data.Month + "/" + Data.Year + "\n"
                + "Itens :\n";
            for(int i = 0; i < itens.Count; i++)
            {
                s = s + itens[i] + "\n";
            }
                s = s + "Total do Pedido: " + valorTotal().ToString("F2", CultureInfo.InvariantCulture);
                return s;
        }
    }
}
