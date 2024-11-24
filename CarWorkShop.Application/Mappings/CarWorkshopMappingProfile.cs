using AutoMapper;
using CarWorkShop.Application.CarWorkshop;
using CarWorkShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.Mappings
{
    public class CarWorkshopMappingProfile : Profile
    {
        public CarWorkshopMappingProfile()
        {

            CreateMap<CarWorkshopDto, CarWorkShop.Domain.Entities.CarWorkShop>()
                .ForMember(e => e.ContactDetails, opt => opt.MapFrom(src => new CarWorkShopContactDetails()
                {
                    City = src.City,
                    phoneNumber = src.phoneNumber,
                    PostalCode = src.PostalCode,
                    Street = src.Street,

                }


                ));


            CreateMap<CarWorkShop.Domain.Entities.CarWorkShop, CarWorkshopDto>()
                .ForMember(dto => dto.Street, opt => opt.MapFrom(src => src.ContactDetails.Street))
                .ForMember(dto => dto.City, opt => opt.MapFrom(src => src.ContactDetails.City))
                .ForMember(dto => dto.PostalCode, opt => opt.MapFrom(src => src.ContactDetails.PostalCode))
                .ForMember(dto => dto.phoneNumber, opt => opt.MapFrom(src => src.ContactDetails.phoneNumber));


        }
    }
}
