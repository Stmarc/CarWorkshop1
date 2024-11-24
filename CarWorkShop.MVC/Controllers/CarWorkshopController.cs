using Microsoft.AspNetCore.Mvc;

using CarWorkShop.Domain.Interfaces;
using CarWorkShop.Application.CarWorkshop;
using MediatR;
using CarWorkShop.Application.CarWorkshop.Commands.CreateCarWorkshop;
using CarWorkShop.Application.CarWorkshop.Queris.GetAllCarWorkshop;
using CarWorkShop.Application.CarWorkshop.Queris.GetCarworkshopByEncodedName;
namespace CarWorkShop.MVC.Controllers
{
    public class CarWorkshopController : Controller
    {
        private IMediator _mediator;

        public CarWorkshopController(IMediator mediator) 
        {
            _mediator = mediator;
        }


        public async Task<IActionResult> Index()
        {
            var carWorkshop = await _mediator.Send(new GetAllCarWorkshopQuery());
            return View(carWorkshop);
        }



        public IActionResult Create()
        {
            
            return View();
        }

        [Route("CarWorkshop/{encodedname}/Details")]
        public async Task<IActionResult> Details(string encodedName)
        {
            var dto = await _mediator.Send(new GetCarworkshopByEncodedNameQuery(encodedName));
            return View(dto);
        }



        [HttpPost]
      public async Task<IActionResult> Create(CreateCarWorkshopCommand command)
        {

            if(!ModelState.IsValid)
            {
                return View(command);

            }
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index)); // TODO: refactor
        }
    }
}
