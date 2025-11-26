using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes_Forms
{
    public partial class Form1 : Form
    {
        int ContadorClick = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
            Lista.Items.Clear();
            //array
            string[] nomes = new string[5];
            nomes[0] = "Romario";
            nomes[1] = "Gabriel";
            nomes[2] = "Alberto";
            nomes[3] = "David";
            nomes[4] = "A remover";

            //lista
            List<string> nomes2 = new List<string>();

            /*
            //Vários meios de se fazer a mesma coisa.
            nomes2.Add("Romario");
            nomes2.Add("Gabriel");
            nomes2.Add("Alberto");
            nomes2.Add("David");
            */

            /*
            Lista.Items.Add(nomes2[0]);
            Lista.Items.Add(nomes2[1]);
            Lista.Items.Add(nomes2[2]);
            Lista.Items.Add(nomes2[3]);
            */

            /*
            int contador = 0;
            foreach (string s in nomes2)
            {
                Lista.Items.Add(nomes2[i]);
                i++;
            }
            */

            nomes2.AddRange(nomes);

            //brincadeira com o ultimo elemento do array
            if (ContadorClick == 1)
            {
                nomes2.Remove("A remover");
                ContadorClick = 0;
                nomes2.Insert(4, "Maria");
            }

            Lista.Items.AddRange(nomes2.ToArray());
            ContadorClick = 1;
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Barco", "Remover"
            };
            if(veiculos.Add("Cavalo"))
            {
                MessageBox.Show("Item adicionado");
            }
            else { MessageBox.Show("Item já existe na lista"); }

            veiculos.Remove("Remover");
            veiculos.Add("Bike");
            string novo = $"Temos {(veiculos.Count)} Veiculos cadastrados";
            veiculos.Add(novo);

            Lista.Items.AddRange(veiculos.ToArray());
        }

        private void btnDic_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "Romario"},
                {2, "Gabriel"},
                {3, "Rafaela"},
                {4, "Romario"},
                {10, "Armando" }
            };

            dic.Add(11, "Romario");
            dic.Add(21, "Gabriel");
            dic.Add(31, "Rafaela");
            dic.Add(32, "Remover");

            dic.Remove(32);

            MessageBox.Show($"Temos {dic.Count()} Alunos");
            MessageBox.Show($"O primeiro aluno é {dic.First().Value}");
            MessageBox.Show($"O primeiro aluno é {dic.Last().Value}");
            MessageBox.Show($"Temos um aluno com numero 21? {dic.ContainsKey(21)}");


            foreach (KeyValuePair<int, string> item in dic)
            {
                Lista.Items.Add(item.Key + " " + item.Value);
            }

        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            SortedList<int, string> sLista = new SortedList<int, string>()
            {
                { 1, "Bolo de fubá" },
                {13, "Bolo de cenoura" },
                {99, "Bolo de maracujá" }
            };
            sLista.Add(33, "Bolo de chocolate");

            foreach (KeyValuePair<int, string> item in sLista.Reverse()) 
            {
                Lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void btnSortDic_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> sdic = new SortedDictionary<int, string>()
            {
                {8, "Romario"},
                {36, "Gabriel"},
                {52, "Rafaela"},
                {4, "Romario"},
                {100, "Armando" }
                
            };


            Lista.Items.Clear();

            MessageBox.Show(sdic.ElementAt(0).ToString());

            foreach (KeyValuePair<int, string> item in sdic)
            {
                Lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Bruno","Romario","Danny","Volin","Flávio"
            };

            Lista.Items.Clear();

            nomes.Add("Armando");

            foreach (string item in nomes)
            {
                Lista.Items.Add(item);
            }
        }

        private void btnFila_Click(object sender, EventArgs e)
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Romario primeiro");
            fila.Enqueue("Arthur Segundo");
            fila.Enqueue("Bob Terceiro");
            fila.Enqueue("Ramon Quarto");
            Lista.Items.Clear();
            MessageBox.Show($"Demos um deque em: " + fila.Dequeue());
            MessageBox.Show($"Temos {fila.Count.ToString()} elementos em fila.");
            MessageBox.Show("Demos um pick em: " + fila.Peek() + " Este agora é o primeiro da fila");
            MessageBox.Show("Agora é: " + fila.Last() + " Este agora é o ultimo da fila");


            foreach (string item in fila)
            {
                Lista.Items.Add(item);
            }
        }

        private void btnPilha_Click(object sender, EventArgs e)
        {
            Stack<string> ordem = new Stack<string>();
            ordem.Push("Romario Primeiro");
            ordem.Push("Gabriel Segundo");
            ordem.Push("Larissa Terceiro");
            MessageBox.Show($"Temos {ordem.Count()} Elementos.");
            MessageBox.Show($"Demos um peek em: {ordem.Peek()}.");
            ordem.Pop();
            Lista.Items.Clear();

            foreach (string item in ordem)
            {
                Lista.Items.Add(item);
            }
        }
    }
}
