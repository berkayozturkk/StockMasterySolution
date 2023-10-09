using Application.Features.Items.Queries.GetListStockExtract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public interface IItemRepository
{
    List<Item> GetListStockExtract(GetListStockExtractQuery getListStockExtractQuery);
}
