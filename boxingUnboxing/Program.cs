// Memória Stack
// Value Types
// Memoria Stack o Garbage Collection não acessa
// bullt-in, structs, enum
Console.Clear();

int x = 25;

int y = x;

Console.WriteLine("x="+x);
Console.WriteLine("y="+y);

x = 32;

Console.WriteLine("---x = 32;---");

Console.WriteLine("x="+x);
Console.WriteLine("y="+y);

// Memoria  Heap 
// Reference Types
// Memoria Stack o Garbage Collection acessa
// Cria uma referencia
// Classes, Objects, Arrays..

var arr = new string[2];
arr[0] = "Item 1";
var arr2 = arr; // nao cria uma copia

Console.WriteLine("arr[0]="+arr[0]);
Console.WriteLine("arr2[0]="+arr2[0]);

Console.WriteLine("---Altera as duas linhas---");

arr[0] = "Item Alterado";

Console.WriteLine("arr[0]="+arr[0]);
Console.WriteLine("arr2[0]="+arr2[0]);

Console.WriteLine("");

Console.WriteLine("---Boxing---");

    // Criando uma variável do tipo valor
    int numeroBoxing = 42;

    // Boxing: armazenando o valor em um objeto
    Boxing boxing1 = new Boxing { Valor = numeroBoxing };

    // Criando um segundo container que referencia o mesmo objeto
    Boxing boxing2 = new Boxing { Valor = boxing1.Valor };

    // Exibindo os valores
    Console.WriteLine($"Valor no boxing1: {boxing1.Valor}");
    Console.WriteLine($"Valor no boxing2: {boxing2.Valor}");

    boxing2 =  boxing1;
    
    boxing1.Valor = 100; 

    // Exibindo os valores após a mudança
    Console.WriteLine($"Novo valor no boxing1: {boxing1.Valor}");
    Console.WriteLine($"Valor no boxing2: {boxing2.Valor}");


Console.WriteLine("");

Console.WriteLine("---Unboxing---");
 object objetoUnboxing = 123; // Boxing
 int numeroUnboxing = (int)objetoUnboxing; // Unboxing
 Console.WriteLine($"Unboxed: {numeroUnboxing}"); // Saída: Unboxed value: 123// Saída: Boxed value: 123

 numeroUnboxing = 321;

 Console.WriteLine($"Unboxed alterado: {numeroUnboxing}"); // Saída: Unboxed value: 123// Saída: Boxed value: 123
 
class Boxing{
    public int Valor { get; set; }
}