using ProductBillingBusiness;
using ProductBillingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductBilling.Controllers
{
    /// <summary>
    /// Permite ejecutar funcionalidades de lectura, creación, actualización y eliminación de productos
    /// </summary>
    [RoutePrefix("api/productos")]
    public class ProductosController : System.Web.Http.ApiController
    {
        /// <summary>
        /// Permite eliminar un producto
        /// </summary>
        /// <param name="Tipo_Documento">Tipo de documento de la persona</param>
        /// <param name="Numero_Documento">Número de identificación de la persona</param>
        /// <param name="Numero_Factura">Número de factura</param>
        /// <returns>OK si eliminó el producto, FALSE si hubo una excepción</returns>
        [HttpDelete]
        [Route("v1/delete")]
        public string Delete_v1(string Tipo_Documento, string Numero_Documento, int Numero_Factura)
        {
            return string.Empty;
        }

        /// <summary>
        /// Permite consultar a un producto
        /// </summary>
        /// <param name="Tipo_Documento">Tipo de documento de la persona</param>
        /// <param name="Numero_Documento">Número de identificación de la persona</param>
        /// <param name="Numero_Factura">Número de factura para consulta individual (Opcional)</param>
        /// <returns>Información asociada al producto</returns>
        [HttpGet]
        [Route("v1/get")]
        public PRODUCTOS Get_v1()
        {
            return ProductosBusiness.GetInstance.Get();
        }

        /// <summary>
        /// Permite crear un nuevo producto
        /// </summary>
        /// <returns>OK si creó el producto, FALSE si hubo una excepción</returns>
        [HttpPost]
        [Route("v1/insert")]
        public string Insert_v1()
        {
            // TODO: Pendiente crear modelos de entrada y salida
            return string.Empty;
        }

        /// <summary>
        /// Permite actualizar una factura asociada a un producto
        /// </summary>
        /// <returns>OK si actualizó el producto, FALSE si hubo una excepción</returns>
        [HttpPatch]
        [Route("v1/update")]
        public string Update_v1()
        {
            // TODO: Pendiente crear modelos de entrada y salida
            return string.Empty;
        }
    }
}
