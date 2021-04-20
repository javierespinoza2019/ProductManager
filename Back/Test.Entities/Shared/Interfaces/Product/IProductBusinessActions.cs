namespace Test.Entities.Shared.Interfaces.Product
{
    using System.Collections.Generic;
    using Test.Entities.Product;
    using Test.Entities.Shared.Interfaces.Common;
    using Test.Entities.Shared.Response;

    /// <summary>
    /// Interface para modulo productos
    /// </summary>
    public interface IProductBusinessActions : IAdd<ProductModel, ResponseCommonModel>, IUpdate<ProductModel, ResponseCommonModel>, IDelete<int, ResponseCommonModel>, IGet<ProductModel, IEnumerable<ProductModel>>, IGet<int, ProductModel> { }
}
