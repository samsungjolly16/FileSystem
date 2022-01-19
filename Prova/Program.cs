using System;
using FileSystemLibrary;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystem_ fs = new FileSystem_("c");
            Directory dp = new Directory("home");
            Directory docs = new Directory("docs");
            File doc1 = new File("doc 1.", 1, "txt");
            Console.WriteLine( fs.Stampa(dp.Nome));
        }
    }
}
