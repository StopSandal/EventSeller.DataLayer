using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesViewModel
{
    public class TokenVM
    {
        public string? AccessToken {get; set;}
        public string? RefreshToken { get; set;}
    }
}
