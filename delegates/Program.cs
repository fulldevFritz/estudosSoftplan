internal class Program
{
    private static void Main(string[] args)
    {
        Action clear = Console.Clear;

        Action<string?> exibir = Console.WriteLine;

        Func<int, int, int> somar = (x, y) => x + y;

        Func<int, int, int> subtrair = (x, y) => x - y;

        Func<int, int, int> multiplicar = (x, y) => x * y;

        Func<int, int, int> dividir = (x, y) => x / y;
        
        clear();
        exibir("--delegates--");
        exibir("");

        exibir("soma: " + somar(1, 1).ToString());
        exibir("");
        exibir("subtracao: " +subtrair(2, 1).ToString());
        exibir("");
        exibir("multiplicacao: "+multiplicar(1, 1).ToString());
        exibir("");
        exibir("divisao: "+dividir(1, 1).ToString());

        DelSoma delSoma = delegate (int x, int y)
        {
            return x + y;
        };

        exibir("");
        exibir("Soma com delegate nomeado: "+delSoma(1, 2).ToString());

        // Uso de callback
        var callback = new Callback();
        exibir("");
        callback.DoWork(result => exibir(result));

        // Uso filter delegate
        var filter = new Filter();
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var evenNumbers = filter.FilterNumbers(numbers, n => n % 2 == 0);
        exibir("");
        exibir("uso de filter");
        evenNumbers.ForEach(x => exibir(x.ToString()));

        exibir("");
        exibir("uso do Predicate ");
        Predicate<int> par = (x) => x % 2 == 0;
        numbers.ForEach(x => exibir($"O numero {x} é par? {par(x).ToString()}" ));
       
    }
}


