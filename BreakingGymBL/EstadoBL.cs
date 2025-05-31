using BreakingGymEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BreakingGymDAL;

namespace BreakingGymBL
{
    public class EstadoBL
    {
        public List<EstadoEN> MostrarEstado()
        {
            return EstadoDAL.MostrarEstado();
        }
        public int GuardarEstado(EstadoEN pestadoEN)
        {
            return EstadoDAL.AgregarEstado(pestadoEN);
        }
        public int EliminarEstado(EstadoEN pestadoEN)
        {
            return EstadoDAL.EliminarEstado(pestadoEN);
        }
        public int ModificarEstado(EstadoEN pestadoEN)
        {
            return EstadoDAL.ModificarEstado(pestadoEN);
        }
    }
}
