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
    public string EndTime { get; set; }
    public int ProductCode { get; set; }

    public class GetListStockExtractQueryHandler :
        IRequestHandler<GetListStockExtractQuery, List<GetListStockExtractListItemDto>>
    {
        public Task<List<GetListStockExtractListItemDto>> Handle(GetListStockExtractQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
