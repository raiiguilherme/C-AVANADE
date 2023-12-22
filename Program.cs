
using C______;

Pessoa pp = new Pessoa();

Queue<int> fila = new Queue<int>();



fila.Enqueue(1000);
fila.Enqueue(10213);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("vamos remover um elemento agr");
fila.Dequeue();

Console.WriteLine("mostrando novamente a fila sem o item retirado");
foreach (int item in fila)
{
    Console.WriteLine(item);
}



























// try
// {
//         string [] linhas = File.ReadAllLines("arquivos/oi.txt");

//         foreach (string lin in linhas)
//      {
//          Console.WriteLine(lin);
// }

// }
// catch (System.Exception e)
// {
//     Console.WriteLine("Deu erro meu chapa, coloque a  "+ e.Message);
    
// }




