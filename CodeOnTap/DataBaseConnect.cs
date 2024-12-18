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
        protected SqlConnection _conn = new SqlConnection("Data Source=WINDOWS-10\\SQLEXPRESS;Initial Catalog=DoAnCSharp;Integrated Security=True");
    }
}
