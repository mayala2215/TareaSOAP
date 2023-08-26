using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TareaServices
{
    /// <summary>
    /// Summary description for services
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class services : System.Web.Services.WebService
    {

        [WebMethod]
        public double calcularVolumenEsfera(double radio)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        }

        [WebMethod]
        public double calcularVolumenCilindro(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        [WebMethod]
        public double calcularVolumenPiramide(double lado1, double lado2, double altura)
        {
            return (lado1 * lado2 * altura) / 3.0;
        }

        [WebMethod]
        public double calcularVolumenConoTruncado(double lado1, double lado2, double altura)
        {
            double radioMayor = lado1 / 2.0;
            double radioMenor = lado2 / 2.0;
            return (Math.PI / 3.0) * altura * (Math.Pow(radioMayor, 2) + Math.Pow(radioMenor, 2) + (radioMayor * radioMenor));
        }
    }


}
