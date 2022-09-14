static void Enter()
{
    Console.WriteLine("Введите количество жлементов массива");
    int N = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[N];

    for(int i = 0; i < array.Length;i++)
    {
        Console.Write("Введите элемент массива - ");
        array[i] = Convert.ToString(Console.ReadLine());
    }  
    OutPut(array); 
}
static void OutPut(string[] lit)
{
    Console.Write("[");
    for(int i = 0; i < lit.Length; i++)
    {
        Console.Write(lit[i]);
        if( i == lit.Length - 1) Console.Write("");
        else Console.Write(", ");
    }
    Console.Write("]");
}
Enter();