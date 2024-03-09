namespace InheritanceTekrar.Business;

public class CategoryPostgreSqlManager : ICategoryRepository
{
    public void Add(Category category)
    {
        Console.WriteLine("Category PostgreSql veri tabanına eklendi. ");
        Console.WriteLine(category);

    }

    public void Update(Category category)
    {
        Console.WriteLine("Category PostgreSql veri tabanında güncellendi. ");
        Console.WriteLine(category);
    }

    public void Delete(Category category)
    {
        Console.WriteLine("Category PostgreSql veri tabanında silindi. ");
        Console.WriteLine(category);
    }

    public void GetAll()
    {
        Console.WriteLine("Kategoriler Listelendi (PostgreSql)");
    }

}
