using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Domain.Entities
{
    public class CarWorkShop
    {
        public  int Id { get; set; }
        public string? Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public CarWorkShopContactDetails ContactDetails { get; set; } = default!;
        public string? About { get; set; }
        public string EncodedName { get; private set; } = default!;
        public int? Kolumna2 { get; set; }
        
        

        public void EncodeName () => EncodedName= Name.ToLower ().Replace(" ","-");
    }
}
