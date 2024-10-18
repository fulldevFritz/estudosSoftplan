using System.Runtime.CompilerServices;

Console.Clear();

var arr = new int [3];

try
{
    // for (int i = 0; i < 10; i++)
    // {
        
    //     //IndexOutOfRangeException
    //     Console.WriteLine(arr[i]);
    // }   

    //ArgumentNullException 
    //Cadastrar(string.Empty);
    //CadastrarGenerico(string.Empty);
    CadastrarMinhaExcecao(string.Empty);
}
// catch (IndexOutOfRangeException ex) {
//     Console.WriteLine("Não encontrei o indice na lista");
//     Console.WriteLine(ex.Message);
// }
// catch(ArgumentNullException ex){
//     Console.WriteLine("Falha ao cadastrar o texto");
//     Console.WriteLine(ex.Message);
// }
catch (MyException ex) {
    Console.WriteLine("Caiu na minha Exceção");
    Console.WriteLine(ex.QuandoAconteceu);
}
catch(Exception ex)
{
    Console.WriteLine("Algo deu errado..");
    Console.WriteLine(ex.Message);
}

static void Cadastrar(string texto){
    if (string.IsNullOrEmpty(texto))
    {
        throw new ArgumentNullException("Não pode ser nulo ou vazio");
    }
}

static void CadastrarGenerico(string texto){
    if (string.IsNullOrEmpty(texto))
    {
        throw new Exception("Não pode ser nulo ou vazio");
    }
}

static void CadastrarMinhaExcecao(string texto){
    if (string.IsNullOrEmpty(texto))
    {
        throw new MyException(DateTime.Now);
    }
}

public class MyException: Exception{
    public MyException(DateTime quandoAconteceu)
    {
        QuandoAconteceu = quandoAconteceu;
    }
    public DateTime QuandoAconteceu { get; set; }
}


