using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnTap
{
    internal class DataBaseConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-EVA6OFD\\SQLEXPRESS;Initial Catalog=DoAnCSharp;Integrated Security=True");
    }
}
