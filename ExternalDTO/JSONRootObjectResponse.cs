using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.ExternalDTO
{
    public class JSONRootObjectResponse<TClass> where TClass : class
    {
        public TClass ProcessPaymentResponse {  get; set; }
    }
}
