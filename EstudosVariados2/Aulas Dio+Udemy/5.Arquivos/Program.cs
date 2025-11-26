using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try { //Tenta

                //string[] linhas = File.ReadAllLines("D:\\Arquivos\\GitHub\\Estudos.net\\10.Exceções\\ExplorandoArquivos\\ExplorandoArquivos\\Arquivos\\Dados.txt");

                new Explorando().Metodo1();
                
                /* foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);

                } */  
            }
            catch(FileNotFoundException ex) //Erro de arquivo não encontrado
            {
                Console.WriteLine("Ocorreu um erro, arquivo não encontrado!");
            }
            catch (DirectoryNotFoundException ex) //Erro de diretório não encontrado
            {
                Console.WriteLine("Ocorreu um erro, diretório não encontrado!");
            }

            catch (Exception ex) //estamos capturando o errro da excessão
            { 
                      Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}"); //e escrevendo ela
            }
            finally // finaly é sempre executado após o catch, mesmo que ocorra alguma excessão.
            {
                Console.WriteLine("Finalizamos aqui");
            }


        }
    }
}
