// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); //path = caminho
string path = @"C:\Dados\";
string file = "arquivo.txt";

if (!Directory.Exists(path))
    Directory.CreateDirectory(path);

if (File.Exists(path + file))
{
    StreamReader sr = new StreamReader(path + file);
    {
        //        sr.ReadLine();
        //        sr.ReadLine();
        //        string thirdLine = sr.ReadLine();

        //        if (thirdLine != null)
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Terceira linha do arquivo:");
        //            Console.WriteLine(thirdLine);
        //        }
        //        else
        //        {
        //            Console.WriteLine("O arquivo tem menos que 3 linhas.");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("File not found: {0}", path + file);
        //}
        string s = sr.ReadToEnd();

        Console.Clear();
        Console.WriteLine(s);
        sr.Close();

        s += "\n";
        s += Console.ReadLine();

        StreamWriter sw = new(path + file);
        sw.WriteLine(s);
        sw.Close();

        Console.Clear();
        Console.WriteLine("Conteudo do arquivo: ");
        StreamReader sr2 = new(path + file);
        Console.WriteLine(sr2.ReadToEnd());
        sr2.Close();

        var retorno = File.ReadLines(path + file).Skip(2).Take(1).First();
        Console.WriteLine(retorno);

        var retorno2 = File.ReadLines(path + file).ElementAt(2);
        Console.WriteLine(retorno2);

        int item = 0;
        foreach (string linha in File.ReadLines(path + file))
        {
           // item++;
           // if (item == 2)
                Console.WriteLine(linha);
        }
    }

    //StreamWriter sw = new(path + file);

    //Console.WriteLine("Informe seu nome: ");
    //string? s = Console.ReadLine();

    //sw.WriteLine(s);

    //Console.WriteLine("Informe seu email: ");
    //s = Console.ReadLine();

    //sw.WriteLine(s);
    //sw.Close();

    //StreamReader sr = new(file);

    //Console.Clear();
    //Console.WriteLine(sr.ReadToEnd());
    //sr.Close();
}