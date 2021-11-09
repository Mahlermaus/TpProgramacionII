using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.accesoDatos
{
     public abstract class AbstractDaoFactory
    {
        public abstract IFacturaDao CrearFactura();

    }
}
