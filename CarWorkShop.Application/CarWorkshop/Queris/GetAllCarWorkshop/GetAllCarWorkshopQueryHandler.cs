using AutoMapper;
using CarWorkShop.Application.CarWorkshop;
using CarWorkShop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.CarWorkshop.Queris.GetAllCarWorkshop
{
    public class GetAllCarWorkshopQueryHandler : IRequestHandler<GetAllCarWorkshopQuery, IEnumerable<CarWorkshopDto>>
    {
        private readonly IMapper _mapper;
        private ICarWorkShopRepository _carWorkShopRepository;

        public GetAllCarWorkshopQueryHandler(ICarWorkShopRepository carWorkShopRepository, IMapper mapper)
        {
            _mapper = mapper;
            _carWorkShopRepository = carWorkShopRepository;
        }


        public async Task<IEnumerable<CarWorkshopDto>> Handle(GetAllCarWorkshopQuery request, CancellationToken cancellationToken)
        {
            var carWorkshops = await _carWorkShopRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<CarWorkshopDto>>(carWorkshops);

            return dtos;
        }
    }
}
