using AutoMapper;
using BitcoinPriceTracking.BE.BusinessLogic.Models;
using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.Shared.Interfaces.Models;
using BitcoinPriceTracking.BE.Shared.Models.DTOs;

namespace BitcoinPriceTracking.BE.BusinessLogic.MappingProfiles
{
	internal class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CryptoData, CryptoDataBaseDTO>().ReverseMap();
			CreateMap<CryptoDataNote, CryptoDataNoteDTO>().ReverseMap();
			CreateMap<CryptoDataNote, CryptoDataNoteEditDTO>().ReverseMap();
			CreateMap<kurzy, kurzyDTO>().ReverseMap();
		}
	}
}
