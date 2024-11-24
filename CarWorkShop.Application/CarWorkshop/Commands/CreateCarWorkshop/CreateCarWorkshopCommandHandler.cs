using AutoMapper;
using CarWorkShop.Application.CarWorkshop;
using CarWorkShop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.CarWorkshop.Commands.CreateCarWorkshop
{
    public class CreateCarWorkshopCommandHandler : IRequestHandler<CreateCarWorkshopCommand>
    {
        private ICarWorkShopRepository _carWorkShopRepository;
        private IMapper _mapper;

        public CreateCarWorkshopCommandHandler(ICarWorkShopRepository carWorkShopRepository, IMapper mapper)
        {
            _carWorkShopRepository = carWorkShopRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateCarWorkshopCommand request, CancellationToken cancellationToken)
        {
            var carWorkshop = _mapper.Map<Domain.Entities.CarWorkShop>(request);

            carWorkshop.EncodeName();

            await _carWorkShopRepository.Create(carWorkshop);

            return Unit.Value;
        }

    }
}
