using FacturacionBackend.accesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionBackend.servicio.implementaciones
{
    public class DaoFactory : AbstractDaoFactory
    {
       
        public override IFacturaDao CrearFactura()
        {
            return new FacturaDao();
        }
    }
}
