namespace Test.BusinessLogic.Product
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Test.DataAccess.Product;
    using Test.Entities.Product;
    using Test.Entities.Shared.Interfaces.Product;
    using Test.Entities.Shared.Response;

    /// <summary>
    /// Capa de contrlador de necogio para modulo productos
    /// </summary>
    public class ProductBusinessLogic : IProductBusinessActions
    {
        /// <summary>
        /// Instancia de acceso a datos para modulo producto
        /// </summary>
        private readonly IProductDataActions productData = null;
        public ProductBusinessLogic(IProductDataActions productData)
        {
            this.productData = productData;
        }
        /// <summary>
        /// Metodo que agrega un producto
        /// </summary>
        /// <param name="item">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<ResponseCommonModel> Add(ProductModel item)
        {
            return await productData.Add(item);
        }
        /// <summary>
        /// Metodo que elimina un producto
        /// </summary>
        /// <param name="id">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<ResponseCommonModel> Delete(int id)
        {
            return await productData.Delete(new ProductModel() { Id = id });
        }
        /// <summary>
        /// Metodo que obtiene un listado de productos
        /// </summary>
        /// <param name="item">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<IEnumerable<ProductModel>> Get(ProductModel item)
        {
            return await productData.Get(item);
        }
        /// <summary>
        /// Metodo que obtiene un producto por su id
        /// </summary>
        /// <param name="id">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<ProductModel> Get(int id)
        {
            var list = await productData.Get(new ProductModel() { Id = id });
            return list.FirstOrDefault();
        }
        /// <summary>
        /// Metodo que actualiza un producto
        /// </summary>
        /// <param name="item">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<ResponseCommonModel> Update(ProductModel item)
        {
            return await productData.Update(item);
        }
    }
}
