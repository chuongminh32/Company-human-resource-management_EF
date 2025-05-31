using System;
using System.Data;
using System.Data.SqlClient;

public class DBConnection
{
    private static string connectionString = "Server=(local);Database=CompanyHRManagement;Trusted_Connection=True;";
    SqlConnection conn = null;
    SqlCommand comm = null;
    SqlDataAdapter da = null;
    public DBConnection()
    {
        conn = new SqlConnection(connectionString);
        comm = conn.CreateCommand();
    }
    public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
    {
        if (conn.State == ConnectionState.Open)
            conn.Close();
        conn.Open();
        comm.CommandText = strSQL;
        comm.CommandType = ct;
        da = new SqlDataAdapter(comm);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, SqlParameter[] parameters = null)
    {
        bool f = false;
        if (conn.State == ConnectionState.Open)
            conn.Close();
        conn.Open();
        comm.CommandText = strSQL;
        comm.CommandType = ct;

        if (parameters != null)
            comm.Parameters.AddRange(parameters);

        try
        {
            comm.ExecuteNonQuery();
            f = true;
        }
        catch (SqlException ex)
        {
            error = ex.Message;
        }
        finally
        {
            conn.Close();
            comm.Parameters.Clear(); // Xóa tham số để tránh lỗi khi gọi lại
        }
        return f;
    }


    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    // 	Trả về một giá trị đơn (dòng đầu tiên, cột đầu tiên của kết quả).Khi chỉ cần lấy một giá trị như COUNT(*), MAX(...), MIN(...), 
    public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result ?? 0; // Trả về 0 nếu DB trả về NULL
            }
        }
    }

    // Trả về nhiều dòng dữ liệu dưới dạng SqlDataReader.
    public static SqlDataReader ExecuteReader(string query, SqlParameter[] parameters = null)
    {
        SqlConnection conn = GetConnection();
        SqlCommand cmd = new SqlCommand(query, conn);

        if (parameters != null)
        {
            cmd.Parameters.AddRange(parameters);
        }

        conn.Open();
        // Sử dụng CommandBehavior.CloseConnection để khi reader bị đóng thì connection cũng tự đóng
        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
    }




}
