using System.Web.Http;

namespace ProductBilling.Controllers
{
    /// <summary>
    /// Permite ejecutar funcionalidades de lectura, creación, actualización y eliminación de facturas
    /// </summary>
    [Authorize]
    [RoutePrefix("api/facturas")]
    public class FacturasController : ApiController
    {
        /// <summary>
        /// Permite eliminar una factura asociada a un cliente (persona)
        /// </summary>
        /// <param name="Tipo_Documento">Tipo de documento de la persona</param>
        /// <param name="Numero_Documento">Número de identificación de la persona</param>
        /// <param name="Numero_Factura">Número de factura</param>
        /// <returns>OK si eliminó la factura, FALSE si hubo una excepción</returns>
        [HttpPatch]
        [Route("v1/delete")]
        public string Delete_v1(string Tipo_Documento, string Numero_Documento, int Numero_Factura)
        {
            return string.Empty;
        }

        /// <summary>
        /// Permite consultar la(s) factura(s) asociada(s) a un cliente (persona)
        /// </summary>
        /// <param name="Tipo_Documento">Tipo de documento de la persona</param>
        /// <param name="Numero_Documento">Número de identificación de la persona</param>
        /// <param name="Numero_Factura">Número de factura para consulta individual (Opcional)</param>
        /// <returns>Información de la(s) factura(s) asociada a la persona</returns>
        [HttpGet]
        [Route("v1/get")]
        public string Get_v1(string Tipo_Documento, string Numero_Documento, int? Numero_Factura)
        {
            return string.Empty;
        }

        /// <summary>
        /// Permite insertar una factura asociada a un cliente (persona)
        /// </summary>
        /// <returns>OK si insertó la factura, FALSE si hubo una excepción</returns>
        [HttpPost]
        [Route("v1/insert")]
        public string Insert_v1()
        {
            // TODO: Pendiente crear modelos de entrada y salida
            return string.Empty;
        }

        /// <summary>
        /// Permite actualizar una factura asociada a un cliente (persona)
        /// </summary>
        /// <returns>OK si actualizó la información, FALSE si hubo una excepción</returns>
        [HttpPatch]
        [Route("v1/update")]
        public string Update_v1()
        {
            // TODO: Pendiente crear modelos de entrada y salida
            return string.Empty;
        }
    }
}
