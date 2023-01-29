// Как посмотреть содержимое папки:

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
string path = @"C:\Users\Admin\Desktop\Учёба\!Разработчик!\3. Знакомство с языками программирования (лекции) - Сергей Камянецкий\Examples\Lesson1\Example001";
CatalogInfo(path);