// Рисование из 1 лекции.
Console.Clear();

Int32 xa = 1;
Int32 ya = 1;
Int32 xb = 1;
Int32 yb = 30;
Int32 xc = 40;
Int32 yc = 30;



Console.WriteLine("Test");
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

/*
Ощибка:
Unhandled exception. System.ArgumentOutOfRangeException: The value must be greater than or equal 
to zero and less than the console's buffer size in that dimension. (Parameter 'top') Actual value was 30.
   at System.ConsolePal.SetCursorPosition(Int32 left, Int32 top)
   at System.Console.SetCursorPosition(Int32 left, Int32 top)
   at Program.<Main>$(String[] args) in F:\Программирование\С#\GBLessons\Lessons_part-1\Example_4\Program.cs:line 15
*/