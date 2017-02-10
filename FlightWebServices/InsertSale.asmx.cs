using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FlightWebServices
{
    /// <summary>
    /// Descripción breve de InsertSale
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class InsertSale : System.Web.Services.WebService
    {

        [WebMethod]
        public Response SaleRequest(int parRow, string parSeat, int parTravel, int parCustomer)
        {
            FlightManager bm = new FlightManager();
            Response result = bm.DoSale(parRow, parSeat, parTravel, parCustomer);
            return result;
        }

        [WebMethod]
        public List<Customer> GetCustomer()
        {
            FlightManager bm = new FlightManager();
            List<Customer> result = bm.GetCustomer();
            return result;
        }
    }
}
