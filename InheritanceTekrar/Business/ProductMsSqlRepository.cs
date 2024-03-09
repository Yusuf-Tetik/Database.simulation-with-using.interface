namespace InheritanceTekrar.Business;

public class ProductMsSqlRepository : IProductRepository
{
    public void Add(Product product)
    {
        Console.WriteLine("Ürünler tablosuna eklendi (MsSQL)");
        Console.WriteLine(product);
    }

    public void Delete(Product product)
    {
        Console.WriteLine("Ürünler tablosundan silindi (MsSQL)");
        Console.WriteLine(product);
    }

    public void GetAll()
    {
        Console.WriteLine("Ürünler Listelendi (MsSQL)");
    }

    public void GetByProductName()
    {
        Console.WriteLine("Ürün ismine göre getirildi (MsSQL)");
    }

    public void GetByStock()
    {
        Console.WriteLine("Ürün stocka göre getirildi (MsSQL)");
    }

    public void Update(Product product)
    {
        Console.WriteLine("Ürünler tablosunda güncellendi (MsSQL)");
        Console.WriteLine(product);
    }
}
