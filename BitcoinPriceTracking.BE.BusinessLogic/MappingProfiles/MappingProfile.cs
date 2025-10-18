using AutoMapper;
using BitcoinPriceTracking.BE.BusinessLogic.Models;
using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.Shared.Interfaces.Models;
using BitcoinPriceTracking.BE.Shared.Shared.DTOs;

namespace BitcoinPriceTracking.BE.BusinessLogic.MappingProfiles
{
	internal class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CryptoData, CryptoDataDto>().ReverseMap();
			CreateMap<kurzy, kurzyDTO>().ReverseMap();
		}
	}
}
