using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Caixa_Encapsulamento
{
    internal class EncapCaixa
    {
        private string _cliente;
        private double _saldo;
        private double _taxa = 10;

        public void Depositar(double valor)
        {
    
            _saldo += valor;
            Console.WriteLine($"Seu saldo é: {_saldo}");
        }

        public void Sacar(double valor)
        {
            valor -= _taxa;
            _saldo = valor;
            Console.WriteLine($"Seu saldo é: {_saldo}");
        }

        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if (value != "Romario" && value !="Gabriel")
                {
                    _cliente = "Visitante";
                    _saldo = 0;
                }
                else
                {
                    _cliente = value;
                    Saldo = 100;
                }
            }
        }
        public double Saldo
        {
            get { return _saldo; }
            private set
            {
                _saldo = value;

            }
        }
    }
}
