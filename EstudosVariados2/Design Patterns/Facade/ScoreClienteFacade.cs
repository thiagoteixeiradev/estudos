using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ScoreClienteFacade
    {
        DetranAPI detran = new();
        SerasaAPI serasa = new();
        ReceitaFederal receita = new();

        public double Score(string CPF, string CNH)
        {

        

            var cpf = "15975312345";
            var cnhValida = detran.CNH("45685235");
            var scoreSerasa = serasa.Score(cpf);
            var cpfAtivo = receita.CPFAtivo(cpf);

            var scoreCheck = scoreSerasa * 0.2;
            var CPFCheck = scoreSerasa * 0.3;
            double Score = scoreSerasa;

            if(!cnhValida)
            {
                Score = Score - scoreCheck;
            }

            if (!cpfAtivo)
            {
                Score = Score - CPFCheck;
            }
            return Score;
        }
    }
}
