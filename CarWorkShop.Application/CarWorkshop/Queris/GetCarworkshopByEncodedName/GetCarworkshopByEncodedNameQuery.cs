using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.CarWorkshop.Queris.GetCarworkshopByEncodedName
{
    public class GetCarworkshopByEncodedNameQuery : IRequest<CarWorkshopDto>
    {
       

        public string EncoodedName { get; set; }

        public GetCarworkshopByEncodedNameQuery(string encodedName)
        {
            EncoodedName = encodedName;
        }
    }
}
