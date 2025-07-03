using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD:Northwind.Server/Entities/ProductsByCategory.cs
namespace Northwind.Server.Entities;
=======
namespace Northwind.Client.Entities;
>>>>>>> 27e4851e4715ee1fbe6428402f3a35d91cc9639f:Northwind.Client/Entities/ProductsByCategory.cs

[Keyless]
public partial class ProductsByCategory
{
    [StringLength(15)]
    public string CategoryName { get; set; } = null!;

    [StringLength(40)]
    public string ProductName { get; set; } = null!;

    [StringLength(20)]
    public string? QuantityPerUnit { get; set; }

    public short? UnitsInStock { get; set; }

    public bool Discontinued { get; set; }
}
