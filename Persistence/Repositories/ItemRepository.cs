using Application.Features.Items.Queries.GetListStockExtract;
using Application.Services;
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

    //public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Item> builder)
    //{
    //    builder.HasNoKey();
    //    builder.ToView("GetStockExtractData");
    //}

    public async Task<List<GetListStockExtractListItemDto>> GetListStockExtract(GetListStockExtractQuery getListStockExtractQuery)
    {
		try
		{
            //var data = _context.Items.ToList();

            //var parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@Malkodu", getListStockExtractQuery.ProductCode),
            //    new SqlParameter("@BaslangicTarihi", getListStockExtractQuery.StartDate.ToString()),
            //    new SqlParameter("@BitisTarihi", getListStockExtractQuery.EndDate.ToString())
            //};

            string execQuery = @$"EXEC GETSTOCKDATA '{getListStockExtractQuery.ProductCode}', '{getListStockExtractQuery.StartDate}', '{getListStockExtractQuery.EndDate}'";

            //var stockDataList = _context.Set<GetListStockExtractListItemDto>()
            //    .FromSqlRaw(execQuery)
            //    .ToList();

            return new List<GetListStockExtractListItemDto>
            {
                new GetListStockExtractListItemDto { ID = 1, Date = 3 },
            };
        }
		catch (Exception ex)
		{
            //Loglanmalı
            //ex.SaveLog();

            return null;
		}

    }
}
