using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaExtensao.ProdutosExtensao
{
    public static class ProdutosExtensao
    {
        public static double MargemLucro(this Produtos produtos)
        {
            try
            {
                var lucroLiquido = produtos.Venda - produtos.Custo;
                var margemLucro = (lucroLiquido / produtos.Venda) * 100;
                return Convert.ToDouble(margemLucro);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao calcular: " + ex.Message);
            }
        }
    }
}
