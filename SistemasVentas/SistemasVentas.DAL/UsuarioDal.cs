using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
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
    }
}
