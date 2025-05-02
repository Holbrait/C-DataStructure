// written by Ibrahim
// 04/17/25

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public int SupplierId { get; set; }
    public double UnitPrice { get; set; }

    public Product() { }

    public Product(int productId, string productName, int categoryId, int supplierId, double unitPrice)
    {
        ProductId = productId;
        ProductName = productName;
        CategoryId = categoryId;
        SupplierId = supplierId;
        UnitPrice = unitPrice;
    }

    public override string ToString()
    {
        return $"ProductId: {ProductId}, Name: {ProductName}, CategoryId: {CategoryId}, SupplierId: {SupplierId}, Price: {UnitPrice}";
    }
}
