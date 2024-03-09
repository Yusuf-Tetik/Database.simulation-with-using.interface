//Bir sistemde ürün kategori ve kullanıcı tabloları olsun
//veritabanı olduğunu varsayalım ve gerekli işlemleri
//simüle edelim.
//Bu işlemleri MsSQL kullandığını varsayarak simüle edelim.
//Bu işlemlerin alternatifi olan PostgreSql oprerasyonlarını da yazalım.


//Polymorphism
using InheritanceTekrar;
using InheritanceTekrar.Business;

Product product = new Product()
{
    Id = 1,
    Name = "Msi Laptop",
    Price = 45000,
    Stock = 100
};

Category category = new Category()
{
    Id = 1,
    Name = "Teknoloji",
};

User user = new User()
{
    Id = 1,
    Name = "Yusuf",
    Email = "Yusuf1632@gmail.com",
    Password = "19051905",
};

Console.WriteLine(user);
Console.WriteLine("**********");
Console.WriteLine(product);
Console.WriteLine("**********"); 
Console.WriteLine(category);

ICategoryRepository sqlCategoryManager = new CategoryPostgreSqlManager();
sqlCategoryManager.Add(category);
Console.WriteLine("***************");
sqlCategoryManager.Update(category);
Console.WriteLine("***************");
sqlCategoryManager.Delete(category);
Console.WriteLine("***************");
sqlCategoryManager.GetAll();

IProductRepository productRepository = new ProductMsSqlRepository();
productRepository.Add(product);
Console.WriteLine("***************");
productRepository.Update(product);
Console.WriteLine("***************");
productRepository.Delete(product);
Console.WriteLine("***************");
productRepository.GetAll();
Console.WriteLine("***************");
productRepository.GetByProductName();
Console.WriteLine("***************");
productRepository.GetByStock();
//IProductRepository productRepository = new ProductPostgreSqlRepository();
//productRepository.Add(product);
//Console.WriteLine("***************");
//productRepository.Update(product);
//Console.WriteLine("***************");
//productRepository.Delete(product);
//Console.WriteLine("***************");
//productRepository.GetAll();



