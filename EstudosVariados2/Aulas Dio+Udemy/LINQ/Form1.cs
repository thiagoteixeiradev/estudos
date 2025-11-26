using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LINQ;

namespace LINQ
{
    public partial class Form1 : Form
    {
        List<string> Lista_Nomes;
        List<int> Lista_Numeros;
        Dictionary<string, double> lista_Produtos;
        Dictionary<string, string> lista_Estados;
        public Form1()
        {
            InitializeComponent();

            #region Lista de nomes
            Lista_Nomes = new List<string>();
            Lista_Nomes.Add("Romario");
            Lista_Nomes.Add("Gaby");
            Lista_Nomes.Add("Felipe");
            Lista_Nomes.Add("Diego");
            Lista_Nomes.Add("Arthur");
            Lista_Nomes.Add("Rodrigo");
            Lista_Nomes.Add("Armando");
            Lista_Nomes.Add("Antonio");
            Lista_Nomes.Add("Roberto");
            Lista_Nomes.Add("Gustavo");
            #endregion

            #region Lista de Numeros
            Lista_Numeros = new List<int>();
            Lista_Numeros.Add(16);
            Lista_Numeros.Add(23);
            Lista_Numeros.Add(28);
            Lista_Numeros.Add(35);
            Lista_Numeros.Add(89);
            Lista_Numeros.Add(2);
            Lista_Numeros.Add(13);
            Lista_Numeros.Add(33);
            Lista_Numeros.Add(44);
            Lista_Numeros.Add(41);
            #endregion

            #region Lista de Produtos
            lista_Produtos = new Dictionary<string, double>();
            lista_Produtos.Add("Teclado USB", 29.99);
            lista_Produtos.Add("Teclado USB Mecanico", 399.99);
            lista_Produtos.Add("Teclado Gamer", 299.99);
            lista_Produtos.Add("Mouse", 49.99);
            lista_Produtos.Add("Monitor", 399.99);
            lista_Produtos.Add("Memória 16GB", 159.99);
            lista_Produtos.Add("Memória 32GB", 200.00);
            lista_Produtos.Add("Processador", 700.00);
            lista_Produtos.Add("HD", 400.00);
            lista_Produtos.Add("SSD", 159.99);
            lista_Produtos.Add("Gabinete ATX", 170.99);
            #endregion

            #region Lista de Estados
            lista_Estados = new Dictionary<string, string>();
            lista_Estados.Add("Rio de Janeiro", "Brasil");
            lista_Estados.Add("Nova York", "Estados Unidos");
            lista_Estados.Add("São Paulo", "Brasil");
            lista_Estados.Add("Porto", "Nova Brasil");
            lista_Estados.Add("Lisboa", "Nova Brasil");
            lista_Estados.Add("Bahia", "Brasil");
            lista_Estados.Add("Paraíba", "Brasil");
            lista_Estados.Add("Algarve", "Nova Brasil");
            lista_Estados.Add("Goiás", "Brasil");
            lista_Estados.Add("Rio de Fevereiro", "Nova Brasil");
            #endregion
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //Palavras chave do linq from, where, select

            //Obtem a fonte dos dados


            //Criar a consulta

            IEnumerable<int> nPar = from num in Lista_Numeros where num % 2 == 0 select num;

            //Executar a consulta

            foreach (int num in nPar)
            {
                lista.Items.Add(num);
            }
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //Palavras chave do linq from, where, select

            //Obtem a fonte dos dados


            //Criar a consulta

            IEnumerable<int> nImpar = from num in Lista_Numeros where num % 2 != 0 select num;

            //Executar a consulta

            foreach (int num in nImpar)
            {
                lista.Items.Add(num);
            }
        }

        private void btnPesquisarNomes_Click(object sender, EventArgs e)
        {
            string pesquisa = txbConsulta.Text;
            IEnumerable<string> pNome = from Nome in Lista_Nomes where Nome.StartsWith(pesquisa) select Nome;
            foreach (string nume in pNome)
            {
                lista.Items.Add(nume);
            }
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            string txt = txbConsulta.Text;
            //Operador de Filtragem
            var retorno = from Nome in Lista_Nomes where Nome.Contains(txt) select Nome;
            foreach (string nume in retorno)
            {
                lista.Items.Add(nume);
            }
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            //ordenação
            lista.Items.Clear();
            string txt = txbConsulta.Text;

            var retorno = from Numero in Lista_Numeros orderby Numero where Numero <= 50 select Numero;
            //orderby ascending descending

            foreach (int nume in retorno)
            {
                lista.Items.Add(nume);
            }
        }

        private void btnOrdenarProdutos_Click(object sender, EventArgs e)
        {
            //ordenação
            lista.Items.Clear();
            string txt = txbConsulta.Text;

            var retorno = from Produto in lista_Produtos orderby Produto.Key select Produto;
            //orderby ascending descending

            foreach (KeyValuePair<String, Double> nume in retorno)
            {
                lista.Items.Add(nume.Key + " R$:" + nume.Value);
            }
        }

        private void BtnOrdenarNomes_Click(object sender, EventArgs e)
        {
            //ordenação
            lista.Items.Clear();
            string txt = txbConsulta.Text;

            var retorno = from Nomes in Lista_Nomes orderby Nomes select Nomes;
            //orderby ascending descending

            foreach (string nume in retorno)
            {
                lista.Items.Add(nume);
            }
        }

        private void btnAgruparEstados_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            txbConsulta.Text = "";

            var retorno = from estado in lista_Estados group estado by estado.Value;

            foreach (var grupo in retorno)
            {
                lista.Items.Add(grupo.Key);

                foreach (var estado in grupo)
                {
                    lista.Items.Add(">" + estado.Key);
                }
            }
        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int contagem = Lista_Nomes.Count();
            int contagem2 = (from nomes in Lista_Nomes where nomes.StartsWith("R") select nomes).Count();
            lista.Items.Add(contagem2 + " Nomes começando com R.");

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            double media = Lista_Numeros.Average();
            var media2 = (from numeros in Lista_Numeros select numeros).Average();
            lista.Items.Add(media + " Media dos valores");

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int soma = (from numeros in Lista_Numeros where numeros < 50 select numeros).Sum();
            lista.Items.Add(soma + " É a soma dos valores menores que 50.");
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            lista.Items.Add(Lista_Numeros.Min() + " Menor valor");
            lista.Items.Add(Lista_Numeros.Max() + " Maior Valor");
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            string maiorNome = Lista_Nomes.Aggregate(Lista_Nomes[0], (maior, proximo) =>
            {
                if (maior.ToString().Length > proximo.ToString().Length)
                {
                    return maior;
                }
                else
                {
                    return proximo;
                }
            });
            lista.Items.Add(maiorNome + " É o maior Nome da Lista");
        }

        private void btnOpElemento_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int Fprimeiro = Lista_Numeros.FirstOrDefault();
            int Fultimo = Lista_Numeros.LastOrDefault();
            int elemento = Lista_Numeros.ElementAt(3);
            lista.Items.Add(Fprimeiro + " Primeiro elemento");
            lista.Items.Add(elemento + " Terceiro elemento");
            lista.Items.Add(Fultimo + " Ultimo elemento");

        }

        private void btnLinqLambda_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            var cons1 = from Nome in Lista_Nomes select Nome; //Linq normal
            var cons2 = Lista_Nomes.Select(Nome => Nome).OrderBy(Nome => Nome); //Linq + Lamdba
            //para decrescente .OrderbyDescending
            lista.Items.AddRange(cons2.ToArray());
        }

        private void btnLingLamdbaWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            var cons1 = from Nome in Lista_Nomes where Nome.StartsWith("R") select Nome;//Normal
            var cons2 = Lista_Nomes.Where(Nome => Nome.StartsWith("R"));//Linq + LAmdba
            lista.Items.AddRange(cons2.ToArray());
        }

        private void btnLamdbaEstados_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            var cons = lista_Estados.GroupBy(estado => estado.Value);

            // Pega apenas a chave de cada agrupamento
            lista.Items.AddRange(cons.Select(g => g.Key).ToArray());
        }
    }
}
