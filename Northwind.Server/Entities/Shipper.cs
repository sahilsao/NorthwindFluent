using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD:Northwind.Server/Entities/Shipper.cs
namespace Northwind.Server.Entities;
=======
namespace Northwind.Client.Entities;
>>>>>>> 27e4851e4715ee1fbe6428402f3a35d91cc9639f:Northwind.Client/Entities/Shipper.cs

public partial class Shipper
{
    [Key]
    [Column("ShipperID")]
    public int ShipperId { get; set; }

    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [StringLength(24)]
    public string? Phone { get; set; }

    [InverseProperty("ShipViaNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
