using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public UsuarioDal() { }
        public void InsertarUsuarioDal(Usuario u)
        {
            string consulta = "insert into usuario values(" + u.IdPersona + ",'" + u.NombreUser + "','" + u.Contrasena + "','" + u.FechaReg + "')";
            conexion.Ejecutar(consulta);
        }

        public DataTable UsuarioDatosDal()
        {
            string consulta = "SELECT USUARIO.IDUSUARIO, (PERSONA.NOMBRE+' '+PERSONA.APELLIDO) NOMBRECOMPLETO, USUARIO.NOMBREUSER, "+
			                  "ROL.NOMBRE AS NOMBREROL, USUARIOROL.FECHAASIGNA "+
                              "FROM  PERSONA INNER JOIN "+
                         "USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN "+
                         "USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN "+
                         "ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
