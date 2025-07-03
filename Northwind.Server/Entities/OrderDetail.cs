using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD:Northwind.Server/Entities/OrderDetail.cs
namespace Northwind.Server.Entities;
=======
namespace Northwind.Client.Entities;
>>>>>>> 27e4851e4715ee1fbe6428402f3a35d91cc9639f:Northwind.Client/Entities/OrderDetail.cs

[PrimaryKey("OrderId", "ProductId")]
[Table("Order Details")]
[Index("OrderId", Name = "OrderID")]
[Index("OrderId", Name = "OrdersOrder_Details")]
[Index("ProductId", Name = "ProductID")]
[Index("ProductId", Name = "ProductsOrder_Details")]
public partial class OrderDetail
{
    [Key]
    [Column("OrderID")]
    public int OrderId { get; set; }

    [Key]
    [Column("ProductID")]
    public int ProductId { get; set; }

    [Column(TypeName = "money")]
    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderDetails")]
    public virtual Order Order { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("OrderDetails")]
    public virtual Product Product { get; set; } = null!;
}
