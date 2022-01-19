using System;
using FileSystemLibrary;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystem_ fs = new FileSystem_("home");
            Directory dp = new Directory("user1");
            Directory docs = new Directory("docs");
            File doc1 = new File("doc 1.", 1, "txt");
            File doc2 = new File("doc 2.", 2, "txt");
            dp.AddElementi(docs);
            dp.AddElementi(doc1);
            dp.AddElementi(doc2);
            fs.Stampa(dp.Nome);
            foreach (Elemento e in dp.Elementi)
            {
                Console.WriteLine(e.Stampa());
            }



        }
    }
}
