using AutoMapper;
using BitcoinPriceTracking.BE.Shared.Models.DTOs;
using BitcoinPriceTracking.Models.MVs;

namespace BitcoinPriceTracking.MappingProfiles
{
	internal class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CryptoDataNoteDTO, CryptoDataReportMV>()
				.ForMember(dest => dest.CryptoDataNoteId, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.CryptoDataId, opt => opt.MapFrom(src => src.CryptoDataId))
				.ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(src => src.TimeStamp))
				.ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.Note))
				.ForMember(dest => dest.PRICE, opt => opt.MapFrom(src => src.CryptoData.PRICE));
		}
	}
}
