using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatabaseManager
    {
        public void AddMessage(string message, string decryptedMessageInWords, string privateKey, string publicKey, string modulus)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Farrukh\Algorithms\Algorithms\Data\DB.mdf;Integrated Security=True";
                string cmdString = "INSERT INTO tbl_message (EncryptedMessage,DecryptedMessage,PrivateKey,PublicKey,Modulus) VALUES (@val1, @val2, @val3,@val4,@val5)";
                using (SqlCommand comm = new SqlCommand(cmdString, conn))
                {
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@val1", message);
                    comm.Parameters.AddWithValue("@val2", decryptedMessageInWords);
                    comm.Parameters.AddWithValue("@val3", privateKey);
                    comm.Parameters.AddWithValue("@val4", publicKey);
                    comm.Parameters.AddWithValue("@val5", modulus);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
