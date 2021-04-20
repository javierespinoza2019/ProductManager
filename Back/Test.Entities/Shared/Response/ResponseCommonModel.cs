namespace Test.Entities.Shared.Response
{
    /// <summary>
    /// Modelo de datos para respuesta generica
    /// </summary>
    public class ResponseCommonModel
    {
        /// <summary>
        /// Indicador de resultado en la respuesta
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Descripcion del resultado en la respuesta
        /// </summary>
        public string Description { get; set; }
    }
}
