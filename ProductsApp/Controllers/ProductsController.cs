using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProductsApp.Models;

using System.Net;
using System;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
     
        
        // по keyword возвращает обект типа Product , который я хочу передать клиенту
          [HttpPost]
        public Product PostProduct()
        {
            var text = Request.Content.ReadAsStringAsync();
        
            var product = ModelProducts.GetProductByKeyword(text.Result);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }
      

        

    }
}