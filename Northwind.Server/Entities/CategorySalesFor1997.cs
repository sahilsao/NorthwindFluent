using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD:Northwind.Server/Entities/CategorySalesFor1997.cs
namespace Northwind.Server.Entities;
=======
namespace Northwind.Client.Entities;
>>>>>>> 27e4851e4715ee1fbe6428402f3a35d91cc9639f:Northwind.Client/Entities/CategorySalesFor1997.cs

[Keyless]
public partial class CategorySalesFor1997
{
    [StringLength(15)]
    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? CategorySales { get; set; }
}
