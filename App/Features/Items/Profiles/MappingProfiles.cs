using Application.Features.Items.Queries.GetListStockExtract;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Items.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<GetListStockExtractListItemDto, GetListStockExtractResponse>().ForMember(destinationMember: sDto => sDto.ID, memberOptions: opt => opt.MapFrom(c => c.ID))
            .ForMember(destinationMember: sDto => sDto.ID, memberOptions: opt => opt.MapFrom(c => c.ID))
            .ForMember(destinationMember: sDto => sDto.TransactionType, memberOptions: opt => opt.MapFrom(c => c.TransactionType))
            .ForMember(destinationMember: sDto => sDto.Date, memberOptions: opt => opt.MapFrom(c => c.Date))
            .ForMember(destinationMember: sDto => sDto.InputAmount, memberOptions: opt => opt.MapFrom(c => c.InputAmount))
            .ForMember(destinationMember: sDto => sDto.OutputAmount, memberOptions: opt => opt.MapFrom(c => c.OutputAmount))
            .ForMember(destinationMember: sDto => sDto.AmountOfStock, memberOptions: opt => opt.MapFrom(c => c.Stock))
            .ReverseMap();
    }
}
