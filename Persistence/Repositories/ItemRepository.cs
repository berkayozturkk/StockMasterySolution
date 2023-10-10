using Application.Features.Items.Queries.GetListStockExtract;
using Application.Services;
using Azure.Core;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;

public class ItemRepository : EfRepositoryBase<BaseDbContext> , IItemRepository/*, IEntityTypeConfiguration<Item>*/
{
    public ItemRepository(BaseDbContext context) : base(context)
    {

    }

    public async Task<List<GetListStockExtractListItemDto>> GetListStockExtract(GetListStockExtractQuery getListStockExtractQuery)
    {
		try
		{
            //var data = _context.Items.ToList();

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Malkodu", getListStockExtractQuery.ProductCode),
                new SqlParameter("@BaslangicTarihi", getListStockExtractQuery.StartDate.ToOADate()),
                new SqlParameter("@BitisTarihi", getListStockExtractQuery.EndDate.ToOADate())
            };

            //int startDate = Convert.ToInt32(getListStockExtractQuery.StartDate.ToOADate());
            //int endDate = Convert.ToInt32(getListStockExtractQuery.EndDate.ToOADate());
            //string productCode = getListStockExtractQuery.ProductCode;
            
            string execQuery = @$"EXEC GetStockExtractData @Malkodu, @BaslangicTarihi, @BitisTarihi";
            var stockDataList = _context.Set<GetListStockExtractListItemDto>()
                .FromSqlRaw(execQuery,parameters)
                .ToList();

            return stockDataList;
        }
		catch (Exception ex)
		{
            //Loglanmalı
            //ex.SaveLog();

            return null;
		}

    }
}
