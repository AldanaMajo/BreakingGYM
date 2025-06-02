using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingGymEN;

namespace BreakingGymDAL
{
    public class CredencialDAL

    {
        public static List<CredencialEN> MostrarCredencial()
        {
            List<CredencialEN> _Lista = new List<CredencialEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("MostrarCredencial", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new CredencialEN
                    {
                        Id = _reader.GetInt32(0),
                        IdUsuario = _reader.GetInt32(1),
                        Usuario = _reader.GetString(2),
                        Contrasenia = _reader.GetString(3)
                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        public static int GuardarCredencial(CredencialEN pcredencialEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("GuardarCredencial", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@IdUsuario", pcredencialEN.IdUsuario));
                _comando.Parameters.Add(new SqlParameter("@Usuario", pcredencialEN.Usuario));
                _comando.Parameters.Add(new SqlParameter("@Contrasenia", pcredencialEN.Contrasenia));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }

        public static int EliminarCredencial(CredencialEN pcredencialEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("EliminarCredencial", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pcredencialEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }

        public static int ModificarCredencial(CredencialEN pcredencialEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("ModificarCredencial", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pcredencialEN.Id));
                _comando.Parameters.Add(new SqlParameter("@IdUsuario", pcredencialEN.IdUsuario));
                _comando.Parameters.Add(new SqlParameter("@Usuario", pcredencialEN.Usuario));
                _comando.Parameters.Add(new SqlParameter("@Contrasenia", pcredencialEN.Contrasenia));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
    }
}
