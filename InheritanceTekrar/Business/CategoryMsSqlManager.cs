using System.Security.Cryptography.X509Certificates;

namespace InheritanceTekrar.Business;

public class CategoryMsSqlManager : ICategoryRepository
{
    public void Add(Category category)
    {
        Console.WriteLine("Category MsSQL veri tabanına eklendi. ");
        Console.WriteLine(category);

    }

    public void Update(Category category)
    {
        Console.WriteLine("Category MsSQl veri tabanında güncellendi. ");
        Console.WriteLine(category);
    }

    public void Delete(Category category)
    {
        Console.WriteLine("Category MsSQl veri tabanında silindi. ");
        Console.WriteLine(category);
    }

    public void GetAll()
    {
        Console.WriteLine("Kategoriler Listelendi (MsSql)");
    }
}
