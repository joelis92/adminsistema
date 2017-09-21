using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SAC
{
    public static class ClaseSAC
    {
        public static void bdManual(
          string equipo,
          string bd,
          string usr,
          string pass,
          ref int conexion
           

         )
        {
            
            try
            {              
                SqlConnection establecerConexion = new SqlConnection("data source = " + equipo + "\\SQLEXPRESS; initial catalog = " + bd + "; user id = " + usr + "; password = " + pass);

                establecerConexion.Open();

                conexion = 1;
            }

            catch (Exception)
            {
                conexion = 0;
            }

        }
        
    }
}
