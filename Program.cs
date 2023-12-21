
using C______;

Pessoa pp = new Pessoa();

int [] array = new int[4];


for(int i=0; i<array.Length; i++){
    Console.WriteLine($"digite o {i+1} numero: ");
    array[i] = int.Parse(Console.ReadLine());
}


for(int i=0; i<array.Length; i++){
    Console.WriteLine(array[i]);

}

DateTime date = DateTime.Now;

Console.WriteLine(date.ToString("HH:mm"));
