using APM.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APM.WebAPI.Controllers
{
    /// <summary>
    /// Controller class is required for the APM sample application. 
    /// Added the Enable CORS attribute (note: EnableCors has replaced EnableCorsAttribute)...
    /// <code>[EnableCors(origins: "http://localhost:2664", headers: "*", methods: "*")]</code>
    /// </summary>
    [EnableCors("http://localhost:2664", "*", "*")]
    public class ProductsController : ApiController
    {
        /// <summary>
        /// GET: api/Products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> Get()
        {
            var productRepository = new ProductRepository();
            return productRepository.Retrieve();
        }

        /// <summary>
        /// GET: api/Products/5
        /// </summary>
        /// <remarks>The Query String parameter name must match the methods parameter name of "search"</remarks>
        /// <param name="search"></param>
        /// <returns></returns>
        public IEnumerable<Product> Get(string search)
        {
            // Query String Part #2: Except and process the Query String parameter.
            // Extending URL Path Part #4: Except and process the extended path.
            var productRepository = new ProductRepository();
            var products = productRepository.Retrieve();
            return products.Where(p => p.ProductCode.Contains(search));
        }

        /// <summary>
        /// POST: api/Products
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// PUT: api/Products/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// DELETE: api/Products/5
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}
