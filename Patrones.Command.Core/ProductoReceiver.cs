using System;

namespace Patrones.Command.Core
{
    public class ProductoReceiver
    {
        public double Cantidad { get; set; }
        public string Nombre { get; set; }

        public void RestarStock(double cant)
        {
            Cantidad = Cantidad - cant;
            Console.WriteLine(string.Format("Quitando {0} unidades", cant));
        }

        public void SumarStock(double cant)
        {
            Cantidad = Cantidad + cant;
            Console.WriteLine(string.Format("Agregando {0} unidades", cant));
        }
    }
}