using AutoMapper;
using FinanceManager.Server.Data.DTOs;
using FinanceManager.Server.Data.Entities;

namespace FinanceManager.Server.Application
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {

            CreateMap<EachPurchaseEntity, EachPurchaseDTO>()
            .ForMember(dest => dest.BillName, opt => opt.MapFrom(src => src.BillName))
            .ForMember(dest => dest.BillAmount, opt => opt.MapFrom(src => src.BillAmount))
            .ForMember(dest => dest.BillDate, opt => opt.MapFrom(src => src.BillDate))
            .ForMember(dest => dest.SelectOption, opt => opt.MapFrom(src => src.SelectOption));

            CreateMap<EachPurchaseDTO, EachPurchaseEntity>()
            .ForMember(dest => dest.BillName, opt => opt.MapFrom(src => src.BillName))
            .ForMember(dest => dest.BillAmount, opt => opt.MapFrom(src => src.BillAmount))
            .ForMember(dest => dest.BillDate, opt => opt.MapFrom(src => src.BillDate))
            .ForMember(dest => dest.SelectOption, opt => opt.MapFrom(src => src.SelectOption));

        }

    }
}
