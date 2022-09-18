/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/
static void Enter()
{
    Console.Write("Введите количество жлементов массива - ");
    int N = Convert.ToInt32(Console.ReadLine());

    string[] arr = new string[N];
    
    for(int i = 0; i < arr.Length;i++)
    {
        Console.Write("Введите элемент массива - ");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    OutPutArray(arr);
    NewArray(arr);
}

static void NewArray(string[] array)
{
    int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
    int max_length = 3;
			
	for (int i = 0; i < length; i++)
	{
		if(array[i].Length <= max_length)
		{
			result[count] = array[i];
			count++;
		}
	}
    Console.WriteLine("");
    Console.Write("Результат: ");
    OutPutArray(result);
}

static void OutPutArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if( i == array.Length - 1) Console.Write("");
        else Console.Write(", ");
    }
    Console.Write("]");
}
Enter();