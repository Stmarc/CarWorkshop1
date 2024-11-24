using AutoMapper;
using CarWorkShop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.CarWorkshop.Queris.GetCarworkshopByEncodedName
{
    public class GetCarworkshopByEncodedNameHandler : IRequestHandler<GetCarworkshopByEncodedNameQuery,CarWorkshopDto>
    {
        private ICarWorkShopRepository _carWorkShopRepository;
        private IMapper _mapper;

        public GetCarworkshopByEncodedNameHandler(ICarWorkShopRepository carWorkShopRepository, IMapper mapper)
        {
            _carWorkShopRepository = carWorkShopRepository;
            _mapper = mapper;
            
        }

        public async Task<CarWorkshopDto> Handle( GetCarworkshopByEncodedNameQuery request, CancellationToken cancellationToken)
        {
            var carWorkshop = await _carWorkShopRepository.GetByEncodedName(request.EncoodedName);
            var dto=_mapper.Map<CarWorkshopDto>(carWorkshop);

            return dto;


        }
    }
}
