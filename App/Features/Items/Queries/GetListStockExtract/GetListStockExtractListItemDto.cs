﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Items.Queries.GetListStockExtract;

public class GetListStockExtractListItemDto
{
    public int ID { get; set; }
    public int TransactionType { get; set; }
    public string DocumentNo { get; set; }
    public int Date { get; set; }
    public int InputAmount { get; set; }
    public int OutputAmount { get; set; }
    public int AmountOfStock { get; set; }
}
