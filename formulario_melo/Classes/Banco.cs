using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace formulario_melo.Classes
{
    class Banco
    {
        public SqlConnection con()
        {
            SqlConnection sql = new SqlConnection("Data Source=MRIADOCARMO-PC\\SQLEXPRESS1;Initial Catalog=form_melo;User id=felipe2;Password=nirvana");
            return sql;
        }
    }
}
