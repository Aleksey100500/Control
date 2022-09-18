В ПАПКЕ "CIRCUIT" НАХОДИТСЯ БЛОК-СХЕМА К ЗАДАЧЕ.
В ПАПКЕ "EXERCISE" УСЛОВИЕ И РЕШЕНИЕ САМОЙ ЗАДАЧИ.


/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/
static void Enter()  // метод входа программы, создание массива с данными с которыми мы будем работать
{
    Console.Write("Введите количество жлементов массива - ");
    int N = Convert.ToInt32(Console.ReadLine());

    string[] arr = new string[N];    // создание массива arr с количеством N элементов в котором будут хранится записанные нами элементы
    
    for(int i = 0; i < arr.Length;i++)
    {
        Console.Write("Введите элемент массива - ");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    OutPutArray(arr); // вызов метода печати на экран массива arr нужен, чтобы увидеть все записанные нами элементы
    NewArray(arr); // вызов метода NewArray для преобразования массива
}

static void NewArray(string[] array)
{
  int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
  int max_length = 3;
			
	for (int i = 0; i < length; i++) // цикл FOR, движение происходит с помощью числовой переменной i 
	{                                    // array[i].Length - длина значения элемента
		if(array[i].Length <= max_length)  // если значение массива array на позиции i подходит по условию, то оно записывается в массив result в позицию count
		{
			result[count] = array[i];
			count++;
		}
	}
    Console.WriteLine("");
    Console.Write("Результат: "); 
    OutPutArray(result); // вызов метода OutPutArray с параметром result
}

static void OutPutArray(string[] array) // печать массива на экран
{
    Console.Write("[");   // вставка знаков "[" в массив array
    for(int i = 0; i < array.Length; i++)  // цикл FOR, движение происходит с помощью числовой переменной i 
    {
        Console.Write(array[i]);   // вывод i ого значения массива array на экран
        if( i == array.Length - 1) Console.Write(""); // вставка знаков " " "," в массив array
        else Console.Write(", ");
    }
    Console.Write("]"); // вставка знаков "]" в массив array
}
Enter();
