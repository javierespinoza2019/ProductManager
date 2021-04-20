namespace Test.Frontend.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Test.Entities.Product;
    using Test.Entities.Shared.Interfaces.Product;
    
    /// <summary>
    /// Controlador de servicios REST para modulo productos
    /// </summary>
    [Route("api/[controller]")]
    [ApiController, EnableCors("AllowOrigin")]
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// Instancia para acceder a capa de logica de negocio en modulo de productos
        /// </summary>
        private readonly IProductBusinessActions productBusiness = null;
        /// <summary>
        /// Constructor de clase
        /// </summary>
        /// <param name="productBusiness">Dependencia de tipo IProductBusinessActions</param>
        public ProductsController(IProductBusinessActions productBusiness)
        {
            this.productBusiness = productBusiness;
        }
        /// <summary>
        /// Metodo que agrega un nuevo producto
        /// </summary>
        /// <returns>Retorna resultado de la peticion</returns>
        [Route("Add")]
        [HttpPost]
        public async Task<IActionResult> Add(ProductModel item)
        {

            return Ok(await productBusiness.Add(item));
        }
        /// <summary>
        /// Metodo que actualiza un nuevo producto
        /// </summary>
        /// <returns>Retorna resultado de la peticion</returns>
        [Route("Update")]
        [HttpPost]
        public async Task<IActionResult> Update(ProductModel item)
        {
            return Ok(await productBusiness.Update(item));
        }
        /// <summary>
        /// Metodo que elimina un nuevo producto
        /// </summary>
        /// <returns>Retorna resultado de la peticion</returns>
        [Route("Delete/{id}")]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await productBusiness.Delete(id));
        }
        /// <summary>
        /// Metodo que actualiza un nuevo producto
        /// </summary>
        /// <returns>Retorna resultado de la peticion</returns>
        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await productBusiness.Get(id));
        }
        /// <summary>
        /// Metodo que actualiza un nuevo producto
        /// </summary>
        /// <returns>Retorna resultado de la carga</returns>
        [HttpPost]
        public async Task<IActionResult> Get(ProductModel filter)
        {
            return Ok(await productBusiness.Get(filter)); //pasar filtros - cambiar a POST
        }
    }
}
