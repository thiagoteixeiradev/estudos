using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _44.HashMd5
{
    internal class Md5
    {
        public string retornarMd5(string objeto)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return retornaHash(md5Hash, objeto);
            }
        }

        public bool CompararMd5(string objetoEntrada, string objetoReservado)
        {
            string objeto = retornarMd5(objetoEntrada);
            if (verificarHash(objeto, objetoReservado))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        private string retornaHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            return sBuilder.ToString();
        }

        private bool verificarHash(string input, string Hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            if (comparar.Compare(input, Hash) == 0)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
            
        }
    }
}
