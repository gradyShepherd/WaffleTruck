using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Data;
/// <summary>
/// Summary description for DataInsert
/// </summary>
public class DataInsert
{
    public DataInsert()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int InsertOrder(string name, string phone, string item)
    {
        DataAccess myAccess = new DataAccess();
        SqlParameter[] parameters = new SqlParameter[3];
        parameters[0] = new SqlParameter("personName", name);
        parameters[1] = new SqlParameter("personPhone", phone);
        parameters[2] = new SqlParameter("item", item);

        string query = "InsertOrder";
        int rows = myAccess.nonQuery(query, parameters);
        return rows;
    }
    public int InsertOrder(string name, string phone)
    {
        DataAccess myAccess = new DataAccess();
        SqlParameter[] parameters = new SqlParameter[2];
        parameters[0] = new SqlParameter("personName", name);
        parameters[1] = new SqlParameter("personPhone", phone);

        string query = "InsertPerson";
        int rows = myAccess.nonQuery(query, parameters);
        return rows;
    }
    public int LoginUser(string username, string password)
    {
        SqlParameter[] parameters = new SqlParameter[2];
        parameters[0] = new SqlParameter("username", username);
        parameters[1] = new SqlParameter("password", password);
        DataAccess myAccess = new DataAccess();

        string query = "GetUser";
        int userId = myAccess.executeScalar(query, parameters);
        return userId;
    }
    public void DisplayData()
    {

    }

}