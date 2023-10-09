using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Items.Queries.GetListStockExtract;

public class GetListStockExtractListItemDto
{
    public string StartDate { get; set; }
    public string EndTime { get; set; }
    public int ProductCode { get; set; }
}
