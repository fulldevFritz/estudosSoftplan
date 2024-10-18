public class Callback
{
    public void DoWork(OperationCompletedHandler callback)
    {
        // Simula uma operação longa
        System.Threading.Thread.Sleep(1000);
        callback("Delegate Callback!");
    }
}