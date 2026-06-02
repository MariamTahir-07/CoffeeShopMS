namespace CoffeeShopMS.Models;


//encapsulation is used, get;set has been given
public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string Role { get; set; } = "Staff";
    public string Created { get; set; } = "";
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public double Price { get; set; }
    public string Description { get; set; } = "";
    public bool IsActive { get; set; } = true;

    public override string ToString() => $"{Name} - Rs.{Price:0.00}";
}

public class Order
{
    public int Id { get; set; }
    public string OrderDate { get; set; } = "";
    public string CustomerName { get; set; } = "";
    public double TotalAmount { get; set; }
    public string Status { get; set; } = "Pending";
    public int CreatedBy { get; set; }
    public List<OrderDetail> Details { get; set; } = new();
}

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; } = "";
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public double SubTotal { get; set; }
}

public class CartItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = "";
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public double SubTotal => Quantity * UnitPrice;
}

// Singleton session
public static class Session
{
    public static User? CurrentUser { get; set; }
}
