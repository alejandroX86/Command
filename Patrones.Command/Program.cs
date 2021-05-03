using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrones.Command.Core;

namespace Patrones.Command.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var empresa = new EmpresaInvoker();
            var producto = new ProductoReceiver();
            producto.Cantidad = 100;


            var ordenAlta = new AltaStockCommand(producto, 10);
            empresa.TomarOrden(ordenAlta);
            var ordenbaja = new BajaStockCommand(producto, 50);
            empresa.TomarOrden(ordenbaja);

            var ordenbaja2 = new BajaStockCommand(producto, 5);
            empresa.TomarOrden(ordenbaja2);
            var ordenbaja3 = new BajaStockCommand(producto, 15);
            empresa.TomarOrden(ordenbaja3);

            var ordenAlta2 = new AltaStockCommand(producto, 100);
            empresa.TomarOrden(ordenAlta2);
            var ordenAlta3 = new AltaStockCommand(producto, 100);
            empresa.TomarOrden(ordenAlta3);


            empresa.ProcesarOrdenes();


            Console.Write(string.Format("Total stock es {0}", producto.Cantidad));
            Console.ReadKey();
        }
    }
}
