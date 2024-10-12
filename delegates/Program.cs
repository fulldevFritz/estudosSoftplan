
Action clear = Console.Clear;

Action<string?> exibir = Console.WriteLine;

Func<int, int, int> somar = (x, y) => x + y;

Func<int, int, int> subtrair = (x, y) => x - y;

Func<int, int, int> multiplicar = (x, y) => x * y;

Func< int, int, int> dividir = (x, y) => x / y;

clear();

exibir(somar(1, 1).ToString());
exibir(subtrair(2, 1).ToString());
exibir(multiplicar(1, 1).ToString());
exibir(dividir(1, 1).ToString());