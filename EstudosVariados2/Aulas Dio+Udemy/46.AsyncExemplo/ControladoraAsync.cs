using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.AsyncExemplo
{
    internal class ControladoraAsync
    {
        //método com retorno
        async Task<bool> Task_Result_Async()
        {
            await Task.Delay(2000);
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }

        //Agora com void
        async Task Task_Void_Async()
        {
            await Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa Longa executada");
        }

        public  async Task Task_LongaDuracao_Async()
        {
            bool isAnoBissexto = await Task_Result_Async();
            await Task.Delay(2000);
            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : "não é")} um ano Bissexto.");
            await Task_Void_Async();
        }
    }
}
