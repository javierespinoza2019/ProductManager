namespace Test.DataAccess.Product
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Test.Entities.Product;
    using Test.Entities.Shared.Interfaces.Product;
    using Test.Entities.Shared.Response;

    /// <summary>
    /// Controlador de acceso a datos para modulo productos
    /// </summary>
    public class ProductDataAccess : IProductDataActions
    {
        /// <summary>
        /// instancia de acceso a datos de productos
        /// </summary>
        private readonly List<ProductModel> products = null;
        /// <summary>
        /// Constructor de clase
        /// </summary>
        public ProductDataAccess()
        {
            if(this.products == null)
            {
                this.products = new List<ProductModel>();
            }            
        }
        /// <summary>
        /// Metodo que agrega un producto
        /// </summary>
        /// <param name="item">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<ResponseCommonModel> Add(ProductModel item)
        {
            return await Task.Run(() =>
            {
                int lastId = 1;
                var listOrdered = products.OrderByDescending(x => x.Id);
                if(listOrdered != null && listOrdered.Any())
                {
                    lastId = listOrdered.First().Id + 1;
                }
                item.Id = lastId;
                products.Add(item);
                return new ResponseCommonModel() { Success = true, Description = "Producto creado correctamente" };
            });            
        }
        /// <summary>
        /// Metodo que elimina un producto
        /// </summary>
        /// <param name="item">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<ResponseCommonModel> Delete(ProductModel item)
        {
            return await Task.Run(() =>
            {
                products.Remove(item);
                return new ResponseCommonModel() { Success = true, Description = "Producto eliminado" };
            });           
        }
        /// <summary>
        /// Metodo que obtiene un listado de productos
        /// </summary>
        /// <param name="item">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<IEnumerable<ProductModel>> Get(ProductModel item)
        {
            return await Task.Run(() =>
            {
                if(item.Id > 0)
                {
                    return products.Where(x => x.Id == item.Id);
                }
                else if(!string.IsNullOrWhiteSpace(item.Name))
                {
                    return products.Where(x => x.Name.Contains(item.Name) || x.Category.Contains(item.Name) || x.Description.Contains(item.Name));
                }
                else
                {
                    return products;
                }                
            });           
        }
        /// <summary>
        /// Metodo que actualiza un producto
        /// </summary>
        /// <param name="item">Informacion del producto</param>
        /// <returns>Respuesta de la peticion</returns>
        public async Task<ResponseCommonModel> Update(ProductModel item)
        {
            return await Task.Run(() =>
            {
                var itemToUpdate = products.FirstOrDefault(x => x.Id == item.Id);
                if (itemToUpdate == null) return new ResponseCommonModel() { Success = false, Description = "Producto NO se actualizo" };

                products.Remove(itemToUpdate);
                products.Add(item);
                return new ResponseCommonModel() { Success = true, Description = "Producto actualizado correctamente" };
            });
        }
    }
}
