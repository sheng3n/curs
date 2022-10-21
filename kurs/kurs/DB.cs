using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kurs
{
    internal class DB
    {
        string connStr = "server=chuc.caseum.ru;port=33333;user=st_3_20_13;database=is_3_20_st13_KURS;password=19288096;";
        MySqlConnection conn = new MySqlConnection("server=chuc.caseum.ru;port=33333;user=st_3_20_13;database=is_3_20_st13_KURS;password=19288096;");

        public void openConn()
        {
            if(conn.State == System.Data.ConnectionState.Closed) //подключение к бд
                conn.Open();
        }

        public void closeConn()
        {
            if (conn.State == System.Data.ConnectionState.Open) //закрытие бд
                conn.Close();
        }

        public MySqlConnection getConn()
        {
            return conn; //возвр соединение 
        }
    }
}
