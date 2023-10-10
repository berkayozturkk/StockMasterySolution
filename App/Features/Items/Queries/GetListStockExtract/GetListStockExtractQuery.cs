using Application.Services;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Items.Queries.GetListStockExtract;

public class GetListStockExtractQuery : IRequest<List<GetListStockExtractResponse>>
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ProductCode { get; set; }

    public class GetListStockExtractQueryHandler :
        IRequestHandler<GetListStockExtractQuery, List<GetListStockExtractResponse>>
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public GetListStockExtractQueryHandler(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<List<GetListStockExtractResponse>> Handle(GetListStockExtractQuery request, CancellationToken cancellationToken)
        {
            List<GetListStockExtractListItemDto> data = await _itemRepository.GetListStockExtract(request);

            List<GetListStockExtractResponse> mappingData = _mapper.Map<List<GetListStockExtractResponse>>(data);

            //logic işletilebilir
            //mappingData.ForEach(item => { });

            return mappingData;
        }
    }
}
