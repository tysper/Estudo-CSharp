using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartaoCredito
{
    public class clsCartao
    {
        public static bool validaCartao(string cartao)
        {
            cartao = cartao.Trim().Replace(".", "").Replace("/", "").Replace(",", "").Trim();
            bool peso = true;
            int somadoProduto = 0;
            for(int i = 0; i < 16; i++)
            {
                int produtoAtual = int.Parse($"{cartao[i]}")*int.Parse(peso?"2":"1");
                somadoProduto += produtoAtual>9? produtoAtual-9: produtoAtual;
                peso = !peso;
            }
            return somadoProduto % 10 == 0;
        }
    }
}
