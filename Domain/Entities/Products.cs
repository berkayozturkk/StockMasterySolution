using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Products
{
    public int ID { get; set; }
    public string ProductCode { get; set; }
    public string ProductName { get; set; }

    public Products()
    {
        
    }

    public Products(int id, string productCode, string productName)
    {
        ID = id;
        ProductCode = productCode;
        ProductName = productName;
    }
}
