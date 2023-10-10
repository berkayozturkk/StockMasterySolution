using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Items.Queries.GetListStockExtract;

public class GetListStockExtractListItemDto
{
    public int ID { get; set; }
    public string TransactionType { get; set; }
    public string DocumentNo { get; set; }
    public DateTime Date { get; set; }
    public decimal InputAmount { get; set; }
    public decimal OutputAmount { get; set; }
    public decimal Stock { get; set; }
}
