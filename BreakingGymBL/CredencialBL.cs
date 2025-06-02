using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingGymDAL;
using BreakingGymEN;

namespace BreakingGymBL
{
    public class CredencialBL
    {
        public List<CredencialEN> MostrarCredencial()
        {
            return CredencialDAL.MostrarCredencial();
        }
        public int GuardarCredencial(CredencialEN pcredencialEN)
        {
            return CredencialDAL.GuardarCredencial(pcredencialEN);
        }
        public int EliminarCredencial(CredencialEN pcredencialEN)
        {
            return CredencialDAL.EliminarCredencial(pcredencialEN);
        }
        public int ModificarCredencial(CredencialEN pcredencialEN)
        {
            return CredencialDAL.ModificarCredencial(pcredencialEN);
        }
    }
}
