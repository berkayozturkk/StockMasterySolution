using Application.Services;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Items.Queries.GetListStockExtract;

public class GetListStockExtractQuery : IRequest<List<GetListStockExtractListItemDto>>
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string ProductCode { get; set; }

    public class GetListStockExtractQueryHandler :
        IRequestHandler<GetListStockExtractQuery, List<GetListStockExtractListItemDto>>
    {
        private readonly IItemRepository _itemRepository;

        public GetListStockExtractQueryHandler(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<List<GetListStockExtractListItemDto>> Handle(GetListStockExtractQuery request, CancellationToken cancellationToken)
        {
            //cast işlemleri
            //request.EndDate = Convert.ToInt32((new DateTime()).ToDate());

            var data = await _itemRepository.GetListStockExtract(request);

            return data;
        }
    }
}
