// Вид 1
/*
void Method1()
{
    Console.WriteLine("Атор - Сергей Грубов");
}
Method1();
*/


// Вид 2
/*
void Method21(string msg, int count)
{
    int i = 0 ;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
Method21(count: 5, msg: "Текст сообщения");
*/

/*
// Вид 3

int Method3()
{
   return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/


// Вид 4
/*
string Method4(int count, string text)
{
   int i = 0;
   string result = string.Empty;

   while (i < count)
   {
        result = result + text;
        i++;
   }
   return result;
}

string res = Method4(5, " zack");
Console.WriteLine(res);
*/


// Вид 4
/*
string Method4(int count, string text)
{
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
   return result;
}

string res = Method4(5, " zack");
Console.WriteLine(res);
*/


// Вид 4 (цикл в цикле)
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/


/*
// Вид 4 (цикл в цикле)
string text = "За 30 лет существования действующего закона о занятости" 
            + "в него более 60 раз вносили изменения и дополнения."
            + " Причина - появление новых форматов занятости - самозанятость, "
            + "платформенная занятость - необходимость их легализации и регулирования.";
// string s = "qwerty"
//             0123
// s[3]  //r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght  = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
*/


// Работа с массивами. 
//Перебрать и расставить элементы от меньшего к большему.

int[] arr = {10, 2, 3, 4, 9, 1, 3, 7, 8, 6};

void FillArray(int[] collection)
{
      int length = collection.Length;
      int index = 0;
      while(index < length)
      {
        collection[index] = new Random().Next(0,2);
        index++;
      }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] array = new int[8]; //Создай новый массив из 8 эл-тов

FillArray(array);  
PrintArray(array);

   



// Выбор сортировки

/*
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/