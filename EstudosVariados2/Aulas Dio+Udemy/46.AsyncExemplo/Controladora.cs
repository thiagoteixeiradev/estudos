using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.AsyncExemplo
{
    internal class Controladora
    {
        //método com retorno
        bool Task_Result()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        //Agora com void
        void Task_Void()
        {
            Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa Longa executada");
        }

        public void Task_LongaDuracao()
        {
            bool isAnoBissexto = Task_Result();

            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : "não é")} um ano Bissexto.");
            Task_Void();
        }
    }
}
