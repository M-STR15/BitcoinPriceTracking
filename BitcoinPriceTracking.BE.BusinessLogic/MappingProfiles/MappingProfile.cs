using AutoMapper;
using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.Shared.Models;
using BitcoinPriceTracking.BE.Shared.Models.DTOs;

namespace BitcoinPriceTracking.BE.BusinessLogic.MappingProfiles
{
	internal class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CryptoData, CryptoDataDto>().ReverseMap();
		}
	}
}
