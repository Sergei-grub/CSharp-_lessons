/// Лекция 7. Рекурсия доп.

/* string NumRecurse(int a, int b)
{
    if (a <= b) return $"{a} " + NumRecurse(a + 1, b);
    else 
    {
        return "End of recurse";
    }
    
}

Console.WriteLine(NumRecurse(1, 10)); 
*/

/* string NumRecurse(int a, int b)
{
    if (a <= b) return NumRecurse(a + 1, b) + $"{a} ";
    else return "Start of recurse ";
    
}

Console.WriteLine(NumRecurse(1, 10));
Console.WriteLine(NumRecurse(1, 10)); 
*/

/// Поиск файлов в каталогах по заданному пути. 2 варианта.

/* void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + "   ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
string path = @"H:\.shortcut-targets-by-id\1nPjiMogbK4b1Gqo0xzo4J7Ks9SmEVgsK\Разработчик\3__Знакомство с языками программирования (лекции)";
CatalogInfo(path); 
*/
/* 
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "   ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"H:\.shortcut-targets-by-id\1nPjiMogbK4b1Gqo0xzo4J7Ks9SmEVgsK\Разработчик";
CatalogInfo(path); 
*/

/// Пирамидки
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on} > {count}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();



// Подсчет фибоначчи
/* 
Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("#### ####     )}")
    fIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMicroseconds);
 */