using System.Collections.Generic;

namespace Patrones.Command.Core
{
    public class EmpresaInvoker
    {
        private List<OrdenCommand> ordenes = new List<OrdenCommand>();

        public void TomarOrden(OrdenCommand cmd)
        {
            ordenes.Add(cmd);
        }

        public void ProcesarOrdenes()
        {
            foreach (var orden in ordenes)
                orden.Ejecutar();
            ordenes.Clear();
        }
    }
}