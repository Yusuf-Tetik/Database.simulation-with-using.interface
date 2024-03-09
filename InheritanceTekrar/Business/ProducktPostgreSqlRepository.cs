namespace InheritanceTekrar.Business;

public class ProductPostgreSqlRepository : IProductRepository
{
    public void Add(Product product)
    {
        Console.WriteLine("Ürünler tablosuna eklendi (PostgreSQL)");
        Console.WriteLine(product);
    }

    public void Delete(Product product)
    {
        Console.WriteLine("Ürünler tablosundan silindi (PostgreSQL)");
        Console.WriteLine(product);
    }

    public void GetAll()
    {
        Console.WriteLine("Ürünler Listelendi (PostgreSQL)");
    }

    public void GetByProductName()
    {
        Console.WriteLine("Ürün ismine göre getirildi (PostgreSQL)");
    }

    public void GetByStock()
    {
        Console.WriteLine("Ürün stocka göre getirildi (PostgreSQL)");
    }

    public void Update(Product product)
    {
        Console.WriteLine("Ürünler tablosunda güncellendi (PostgreSQL)");
        Console.WriteLine(product);
    }
}
