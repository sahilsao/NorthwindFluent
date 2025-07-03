using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD:Northwind.Server/Entities/OrderSubtotal.cs
namespace Northwind.Server.Entities;
=======
namespace Northwind.Client.Entities;
>>>>>>> 27e4851e4715ee1fbe6428402f3a35d91cc9639f:Northwind.Client/Entities/OrderSubtotal.cs

[Keyless]
public partial class OrderSubtotal
{
    [Column("OrderID")]
    public int OrderId { get; set; }

    [Column(TypeName = "money")]
    public decimal? Subtotal { get; set; }
}
