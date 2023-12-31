﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Item
{
    public int ID { get; set; }
    public short TransactionType { get; set; }
    public string DocumentNo { get; set; }
    public int Date { get; set; }
    public string ProductCode { get; set; }
    public decimal Amount { get; set; }
    public decimal Price { get; set; }
    public decimal Salary { get; set; }
    public string Unit { get; set; }

    public Item()
    {
        
    }

    //public Item(int id, int transactionType, string documentNo, int date, string productCode, int amount, int price, int salary, string unit)
    //{
    //    ID = id;
    //    TransactionType = transactionType;
    //    DocumentNo = documentNo;
    //    Date = date;
    //    ProductCode = productCode;
    //    Amount = amount;
    //    Price = price;
    //    Salary = salary;
    //    Unit = unit;
    //}
}
