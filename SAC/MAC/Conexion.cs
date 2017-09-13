using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MAC
{
    public static class Conexion
    {
        public static void bdManual(
           string equipo,
           string bd,
           string usr,
           string pass
          
          )
        {
            try
            {

                SqlConnection establecerConexion = new SqlConnection("data source = " + equipo  +"\\SQLEXPRESS; initial catalog = " + bd + "; user id = "+ usr +"; password = "+ pass);

                establecerConexion.Open();
              
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
