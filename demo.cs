using System;
using System.Text;
namespace demo{


public abstract class Product{
    protected string productId;
    protected string name;
    protected double price;
    protected string producer;

    public Product(string productId, string name, double price, string producer)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
        this.producer = producer;
    }

    public abstract double computeTax();
}

public class Book : Product{
    public Book(string productId, string name, double price, string producer) 
    : base(productId, name, price, producer){
    }

    public override double computeTax(){
        return price * 0.08; 
    }
}

public class MobilePhone : Product{
    public MobilePhone(string productId, string name, double price, string producer)
        : base(productId, name, price, producer){
    }

    public override double computeTax()
    {
        return price * 0.1; 
    }
}

 class Program{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Product[] products = new Product[6];
        products[0] = new Book("1", "sách thiên đường", 4, "kim dung 1");
        products[1] = new Book("2", "sách địa ngục", 5, "kim dung 2");
        products[2] = new Book("3", "sách trái đất", 6, "kim dung 3");
        products[3] = new MobilePhone("1", "12pro max", 19, "apple");
        products[4] = new MobilePhone("2", "13pro max", 35, "apple");
        products[5] = new MobilePhone("3", "14pro max", 53, "apple");

        double totalBookTax = 0;
        double totalMobilePhoneTax = 0;

        foreach (Product product in products){
            if (product is Book)
                totalBookTax =  totalBookTax +(product.computeTax());
            else if (product is MobilePhone)
               totalMobilePhoneTax = totalMobilePhoneTax + (product.computeTax());
        }

        Console.WriteLine("thuế của sách là: $" + totalBookTax);
        Console.WriteLine("thuế của điện thoại là: $" + totalMobilePhoneTax);
    }
}
}