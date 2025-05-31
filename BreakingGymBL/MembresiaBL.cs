using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingGymEN;
using BreakingGymDAL;

namespace BreakingGymBL
{
    public class MembresiaBL
    {
        public List<MembresiaEN> MostrarMembresia()
        {
            return MembresiaDAL.MostrarMembresia();
        }
        public static List<MembresiaEN> BuscarMembresia(string nombre)
        {
            return MembresiaDAL.BuscarMembresia(nombre);
        }
        public int GuardarMembresia(MembresiaEN pmembresiaEN)
        {
            return MembresiaDAL.AgregarMembresia(pmembresiaEN);
        }
        public int EliminarMembresia(MembresiaEN pmembresiaEN)
        {
            return MembresiaDAL.EliminarMembresia(pmembresiaEN);
        }
        public int ModificarMembresia(MembresiaEN pmembresiaEN)
        {
            return MembresiaDAL.ModificarMembresia(pmembresiaEN);
        }
    }
}
