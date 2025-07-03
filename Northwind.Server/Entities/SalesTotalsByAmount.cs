using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD:Northwind.Server/Entities/SalesTotalsByAmount.cs
namespace Northwind.Server.Entities;
=======
namespace Northwind.Client.Entities;
>>>>>>> 27e4851e4715ee1fbe6428402f3a35d91cc9639f:Northwind.Client/Entities/SalesTotalsByAmount.cs

[Keyless]
public partial class SalesTotalsByAmount
{
    [Column(TypeName = "money")]
    public decimal? SaleAmount { get; set; }

    [Column("OrderID")]
    public int OrderId { get; set; }

    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ShippedDate { get; set; }
}
