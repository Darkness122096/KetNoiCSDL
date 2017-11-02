using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoaiSP
/// </summary>
public class LoaiSP
{
    public LoaiSP()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    SqlConnection sqlcon;
    SqlCommand sqlcmd;
    SqlDataAdapter sqlAdap;
    string strCon = ConfigurationManager.ConnectionStrings["QuanLyBanHang"].ConnectionString;
    public DataSet _Select()
    {
        DataSet ds = new DataSet();
        sqlcon = new SqlConnection(strCon);
        string query = @"select * from LoaiSanPham";
        sqlcmd = new SqlCommand(query, sqlcon);
        try
        {
            sqlcon.Open();
            sqlAdap = new SqlDataAdapter(sqlcmd);
            sqlAdap.Fill(ds);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString());
        }
        finally { if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); } }
        return ds;
    }
}