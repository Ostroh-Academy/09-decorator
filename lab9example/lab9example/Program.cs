using System;

public interface IProduct
{
    string Name { get; }
    decimal Price { get; }
}

public class Product : IProduct
{
    public string Name { get; }
    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

public abstract class ProductDecorator : IProduct
{
    protected IProduct _product;

    public ProductDecorator(IProduct product)
    {
        _product = product;
    }

    public virtual string Name => _product.Name;

    public virtual decimal Price => _product.Price;
}

public class WarrantyDecorator : ProductDecorator
{
    public WarrantyDecorator(IProduct product) : base(product) { }

    public override string Name => $"{_product.Name} + Warranty";

    public override decimal Price => _product.Price + 10.0m;
}

public class DiscountDecorator : ProductDecorator
{
    private decimal _discount;

    public DiscountDecorator(IProduct product, decimal discount) : base(product)
    {
        _discount = discount;
    }

    public override string Name => $"{_product.Name} - Discount {_discount}%";

    public override decimal Price => _product.Price * (1 - _discount / 100);
}

class Program
{
    static void Main(string[] args)
    {
        IProduct product = new Product("Laptop", 1000.0m);
        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");

        IProduct productWithWarranty = new WarrantyDecorator(product);
        Console.WriteLine($"Product with Warranty: {productWithWarranty.Name}, Price: {productWithWarranty.Price}");

        IProduct productWithDiscountAndWarranty = new DiscountDecorator(productWithWarranty, 15);
        Console.WriteLine($"Product with Discount and Warranty: {productWithDiscountAndWarranty.Name}, Price: {productWithDiscountAndWarranty.Price}");
    }
}
