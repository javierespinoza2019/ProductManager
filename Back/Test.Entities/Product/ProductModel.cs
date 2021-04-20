namespace Test.Entities.Product
{
    /// <summary>
    /// Modelos de datos para productos
    /// </summary>
    public class ProductModel
    {
        /// <summary>
        /// Identificador del producto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Cantidad de producto
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// Descripcion del producto
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Categoria del producto
        /// </summary>
        public string Category { get; set; }
    }
}
