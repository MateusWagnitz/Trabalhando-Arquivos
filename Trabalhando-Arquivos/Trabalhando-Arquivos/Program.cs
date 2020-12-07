#region Teoria

//File, FileInfo
//• Namespace System.IO
//• Realiza operações com arquivos (create, copy, delete, move, open, etc.) e
//  ajuda na criação de objetos FileStream.
//• File
//• static members (simples, mas realiza verificação de segurança para cada operação)
//• https://msdn.microsoft.com/en-us/library/system.io.file(v=vs.110).aspx
//• FileInfo
//• instance members
//• https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx

//_________________________________________________________________________________________
//FileStream
//https://msdn.microsoft.com/en-us/library/system.io.filestream(v=vs.90).aspx
//Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura
//e escrita.
//Suporte a dados binários.
//Instanciação:
//• Vários construtores
//• File / FileInfo

//_________________________________________________________________________________________
//StreamReader
//https://msdn.microsoft.com/en-us/library/system.io.streamreader(v=vs.90).aspx
//É uma stream capaz de ler caracteres a partir de uma stream binária (ex:
//FileStream).
//Suporte a dados no formato de texto.
//Instanciação:
//• Vários construtores
//• File / FileInfo


#endregion



using System;
using System.IO;

            // sem o @ teria que deixar com barras duplas "C:\\Temp\\file1.txt"
namespace Trabalhando_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            #region File/FileInfo
            //string sourcePath = @"c:\temp\file1.txt";
            //string targetPath = @"c:\temp\file2.txt";
            //try
            //{
            //    File.Copy(sourcePath, targetPath);
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region StreamReader
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred"); //caso ocorra um erro
                Console.WriteLine(e.Message);
            }
            finally //para fechar de forma manual o SR
            {
                if (sr != null) sr.Close();  //fechando o StreamReader
                if (fs != null) fs.Close();  //fechando o Filestream
            }

            #endregion


        }

    }
    
}
