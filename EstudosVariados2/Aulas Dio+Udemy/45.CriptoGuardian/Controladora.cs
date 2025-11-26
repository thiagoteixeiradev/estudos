using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Linq.Expressions;

namespace _45.CriptoGuardian
{
    public class Controladora
    {
        //Parametros, e escopo global
        public static CspParameters cspp;
        public static RSACryptoServiceProvider rsa;

        //caminhos para a fonte das chaves e arquivo
        private static string _encrFolder;
        public static string encrFolder
        {
            get => _encrFolder;
            set
            {
                _encrFolder = value;
                PubkeyFile = Path.Combine(_encrFolder, "rsaPublicKey.txt");
            }
        }

        public static string dcrFolder { get; set; }
        public static string srcFolder { get; set; }

        //chave pública
        private static string PubkeyFile;



        //Chave com o nome para private/public key pair.
        public static string Keyname;

        public static string CreateAsmKeys()
        {
            string result = "";

            //armazena a key no container
            if (string.IsNullOrEmpty(Keyname))
            {
                result = "Chave pública não definida";
                return result;
            }

            cspp.KeyContainerName = Keyname;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly) 
            {
                result = "Key: " + cspp.KeyContainerName + " - Somente pública";
            }
            else
            {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;
        }

        //Exporta a chave pública para um arquivo
        public static bool ExportPublicKey()
        {
            bool result = true;

            if (rsa == null)
            {
                return false;
            }

            if (!Directory.Exists(encrFolder))
            {
                Directory.CreateDirectory(encrFolder);
            }

            StreamWriter sw = new StreamWriter(PubkeyFile, false);
            try
            {
                sw.Write(rsa.ToXmlString(false));
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            finally
            {
                sw.Close();
            }
            return result;
        }

        public static string ImportpublicKey()
        {
            string result = "";

            if (!File.Exists(PubkeyFile))
            {
                result = "Arquivo de chave pública não encontrado.";
                return result;
            }

            if (string.IsNullOrEmpty(Keyname))
            {
                result = "Chave pública não definida";
                return result;
            }

            StreamReader sr = new StreamReader(PubkeyFile);

            try
            {
                cspp.KeyContainerName = Keyname;
                rsa = new RSACryptoServiceProvider(cspp);
                string txtKey = sr.ReadToEnd();
                rsa.FromXmlString(txtKey);
                rsa.PersistKeyInCsp = true;

                if(rsa.PublicOnly)
                {
                    result = "Key: " + cspp.KeyContainerName + " - Somente pública";
                }
                else
                {
                    result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }

            return result;
        }

        //Criar a chave privada
        public static string GetPrivateKey()
        {
            string result = "";

            if (string.IsNullOrEmpty(Keyname))
            {
                result = "Chave pública não definida";
                return result;
            }

            cspp.KeyContainerName = Keyname;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly)
            {
                result = "Key: " + cspp.KeyContainerName + " - Somente pública";
            }
            else
            {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }


            return result;
        }

        //Criptografar Arquivo
        public static string EncryptFile(string inFile)
        {
            Aes aes = Aes.Create(); // Este método trabalhar com criptografia simétrica
            ICryptoTransform transform = aes.CreateEncryptor();

            //Usar RSA crypto service provider para criptografar a chave, rsa é instanciado anteiormente (cspp)
            byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);

            //Cria as matrizes de bytes para conter os valores de comprimento da chave e IV
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            /* Escreva no filestream, para o arquivo encriptado:
             * comprimento da chave
             * comprimento do IV
             * chave encriptada
             * IV
             * o conteúdo da cifra encriptada */
            int startFileName = inFile.LastIndexOf("\\") + 1;//pega o 1 caractere
            //vou criar o nome do arquivo de saída.
            string outFile = Path.Combine(encrFolder, Path.GetFileName(inFile) + ".enc");


            try
            {
                using(FileStream outFs = new FileStream(outFile, FileMode.Create))
                {
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(LenIV, 0, 4);
                    outFs.Write(keyEncrypted, 0, lKey);
                    outFs.Write(aes.IV, 0, lIV);

                    //Escrevendo o texto cifrado com o cryptostream
                    using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        //Vamos criptografar por blocos
                        int count = 0;
                        int deslocamento = 0;

                        //tamanho do bloco
                        int blockSizeByte = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeByte];
                        int bytesRead = 0;

                        //Pegando conteudo do arquivo original
                        using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                        {
                            do
                            {
                                count = inFs.Read(data, 0, blockSizeByte);
                                deslocamento += count;
                                outStreamEncrypted.Write(data, 0, count);
                                bytesRead += blockSizeByte;
                            }
                            while (count > 0);
                            inFs.Close();
                        }
                        outStreamEncrypted.FlushFinalBlock();
                        outStreamEncrypted.Close();
                    }
                    outFs.Close();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return $"Arquivo criptografado. \nOrigem: {inFile}\nDestino: {outFile}";

        }


        //Descriptografa Arquivo
        public static string DecryptFile(string inFile)
        {
            //Criar a instancia do aes para descriptografar
            Aes aes = Aes.Create();

            //matrizes de byte para captar o tamanho da chave encriptada e IV.
            //lembrando que os valores foram armazenados em 4 bytes no inicio do pacote.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            //Construindo nome do arquivo descriptografado
            string outFile = Path.Combine(dcrFolder, Path.GetFileNameWithoutExtension(inFile));

            try
            {
                //usar Filestream (inFs) e salvar no OutFs, arquvio de saída.
                using (FileStream inFs = new FileStream(Path.Combine(encrFolder, inFile), FileMode.Open))
                {
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Read(LenK, 0, 4);
                    inFs.Seek(4, SeekOrigin.Begin);
                    inFs.Read(LenIV, 0, 4);

                    //Convertendo os comprimentos para inteiros
                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    //Determinando o inico do texto(starC) e comprimento(lens)
                    int startC = lenK + lenIV + 8;
                    int lenC = (int)inFs.Length - startC;

                    //Criando matrizes de bytes para a aes encriptado, IV, e o txt cifrado
                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];

                    //Extriar a chave e IV, após o indice 8
                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Seek(8 + lenK, SeekOrigin.Begin);
                    inFs.Read(IV, 0, lenIV);

                    if(!Directory.Exists(dcrFolder))
                    {
                        Directory.CreateDirectory(dcrFolder);
                    }

                    //Descriptografar a chave AES
                    byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);
                    //descriptografar a chave
                    ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);
                    //descriptografar o texto cifrado (infs) para o arquivo descriptografado (outFs)
                    using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                    {
                        int count = 0;
                        int offSet = 0;

                        //novamente, ler arquivo em blocos
                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];
                        //fazendo isto economizamos memória e podemos lidar com arquivos grandes

                        //Vamos ao incio do texto cifrado
                        inFs.Seek(startC, SeekOrigin.Begin);
                        using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                        {
                            do
                            {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offSet += count;
                                outStreamDecrypted.Write(data, 0, count);
                            }
                            while (count > 0);

                            outStreamDecrypted.FlushFinalBlock();
                            outStreamDecrypted.Close();
                        }
                        outFs.Close();

                    }
                    inFs.Close();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return $"Arquivo descriptografado. \nOrigem: {inFile}\nDestino: {outFile}";
        }
    }
}
