using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLibrary
{
    public class FileSystem_
    {
        private string Nome { get; }
        public FileSystem_(string nome)
        {
            Nome = nome;
        }

        public void  Stampa(string n1)
        {
            string s="";
            Directory dp = new Directory(n1);
            s+= "/" + Nome + "\n" + "|--/" + dp.Nome;
            Console.Write(s);
            
        }
    }
}
