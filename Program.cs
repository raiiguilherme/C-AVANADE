
using C______;

Pessoa pp = new Pessoa();

try
{
        string [] linhas = File.ReadAllLines("arquivos/oi.txt");

        foreach (string lin in linhas)
     {
         Console.WriteLine(lin);
}

}
catch (System.Exception e)
{
    Console.WriteLine("Deu erro meu chapa "+ e.Message);
    
}




