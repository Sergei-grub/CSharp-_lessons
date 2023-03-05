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

string res = Method4(10000, " zack");
Console.WriteLine(res);