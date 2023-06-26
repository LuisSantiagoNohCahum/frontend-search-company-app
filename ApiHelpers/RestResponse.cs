using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace frontend_app.ApiHelpers
{
    public class RestResponse<T> where T:class
    {
        /* public IEnumerable<T>? Data {get; set;} */
        public T? Data {get; set;}

        public bool Success {get; set;}
    }
}