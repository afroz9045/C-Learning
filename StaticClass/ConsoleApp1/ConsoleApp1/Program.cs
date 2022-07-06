static class Product
{
    public static int ProductId;
    public static string ProductName;
    public static int ProductPrice;

    static Product()
    {
        ProductId = 111;
        ProductName = "Guitar";
        ProductPrice = 5000;
    }
    public static void GetProductDetails()
    {
        Console.WriteLine($"Product id is:{ProductId}");
        Console.WriteLine($"Product Name is:{ProductName}");
        Console.WriteLine($"Product id is:{ProductPrice}");
    }
    public static void GetDiscount()
    {
        int DiscountAmount = ProductPrice / 10;
        Console.WriteLine($"Your discount amount is: {DiscountAmount}");
        Console.WriteLine($"Total cost of product  is :{ProductPrice - DiscountAmount}");
    }
}
class Program
{
    public static void Main()
    {
        Product.GetProductDetails();
        Product.GetDiscount();
    }
}