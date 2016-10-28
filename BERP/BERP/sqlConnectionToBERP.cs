using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BERP
{
    public class SQLConnectionToBERP
    {
        SqlConnection sqlToBERP = new SqlConnection(@"
            Data Source=BRADFORD-DB;
            Integrated Security=False;
            User ID=BERP;
            Password=berp;
            Connect Timeout=15;
            Encrypt=False;
            TrustServerCertificate=True;
            ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False");

        public SqlConnection ActiveCon()
        {
            if (sqlToBERP.State == ConnectionState.Closed)
            {
                sqlToBERP.Open();
            }
            return sqlToBERP;
        }
    }
}
