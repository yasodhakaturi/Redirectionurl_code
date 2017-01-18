using Analytics.Helpers.Utility;
//using Analytics.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Analytics.Helpers.BO
{
    public class DataInsertionBO
    {
        shortenURLEntities dc = new shortenURLEntities();
        SqlConnection lSQLConn = null;
        SqlCommand lSQLCmd = new SqlCommand();
        string connStr = "";
        public void InsertUIDdata(int fk_rid,int? fk_clientid,string referencenumber, string longurl, string mobilenumber)
        {
            connStr = ConfigurationManager.ConnectionStrings["shortenURLConnectionString"].ConnectionString;
            try
            {
                // create and open a connection object
                lSQLConn = new SqlConnection(connStr);
                lSQLConn.Open();
                lSQLCmd.CommandType = CommandType.StoredProcedure;
                lSQLCmd.CommandText = "InsertUIDData";
                lSQLCmd.Parameters.Add(new SqlParameter("@fk_rid", fk_rid));
                lSQLCmd.Parameters.Add(new SqlParameter("@fk_clientid", fk_clientid));
                lSQLCmd.Parameters.Add(new SqlParameter("@referencenumber", referencenumber));
                lSQLCmd.Parameters.Add(new SqlParameter("@longurl", longurl));
                lSQLCmd.Parameters.Add(new SqlParameter("@mobilenumber", mobilenumber));
                lSQLCmd.Connection = lSQLConn;
                lSQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                ErrorLogs.LogErrorData(ex.StackTrace, ex.InnerException.ToString());
            }
            finally
            {
                lSQLCmd.Dispose();
                lSQLConn.Close();
            }
        }
        public void InsertRIDdata(string referencenumber, string pwd,int clientid)
        {
            SqlConnection lSQLConn = null;
            SqlCommand lSQLCmd = new SqlCommand();
            string connStr = "";
            connStr = ConfigurationManager.ConnectionStrings["shortenURLConnectionString"].ConnectionString;
            try
            {
                // create and open a connection object
                lSQLConn = new SqlConnection(connStr);
                lSQLConn.Open();
                lSQLCmd.CommandType = CommandType.StoredProcedure;
                lSQLCmd.CommandText = "InsertRIDData";
                lSQLCmd.Parameters.Add(new SqlParameter("@referencenumber", referencenumber));
                lSQLCmd.Parameters.Add(new SqlParameter("@pwd", pwd));
                lSQLCmd.Parameters.Add(new SqlParameter("@clientid", clientid));

                lSQLCmd.Connection = lSQLConn;
                lSQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ErrorLogs.LogErrorData(ex.StackTrace, ex.InnerException.ToString());

            }
            finally
            {
                lSQLCmd.Dispose();
                lSQLConn.Close();
            }
        }
        public void InsertShortUrldata(string ipv4, string ipv6, string browser, string browser_version, string city, string Region, string country, string countrycode, string req_url, string useragent, string hostname, string devicetype, string ismobiledevice,int? fk_uid,int? fk_rid,int? FK_clientid,int uniqueid)
        {
            SqlConnection lSQLConn = null;
            SqlCommand lSQLCmd = new SqlCommand();
            string connStr = "";
            connStr = ConfigurationManager.ConnectionStrings["shortenURLConnectionString"].ConnectionString;
            try
            {
                // create and open a connection object
                lSQLConn = new SqlConnection(connStr);
                lSQLConn.Open();
                lSQLCmd.CommandType = CommandType.StoredProcedure;
                lSQLCmd.CommandText = "InsertSHORTURLData";
                lSQLCmd.Parameters.Add(new SqlParameter("@ipv4", ipv4));
                lSQLCmd.Parameters.Add(new SqlParameter("@ipv6", ipv6));
                lSQLCmd.Parameters.Add(new SqlParameter("@browser", browser));
                lSQLCmd.Parameters.Add(new SqlParameter("@browser_version", browser_version));
                lSQLCmd.Parameters.Add(new SqlParameter("@city", city));
                lSQLCmd.Parameters.Add(new SqlParameter("@Region", Region));
                lSQLCmd.Parameters.Add(new SqlParameter("@country", country));
                lSQLCmd.Parameters.Add(new SqlParameter("@countrycode", countrycode));
                lSQLCmd.Parameters.Add(new SqlParameter("@req_url", req_url));
                lSQLCmd.Parameters.Add(new SqlParameter("@useragent", useragent));
                lSQLCmd.Parameters.Add(new SqlParameter("@hostname", hostname));
                lSQLCmd.Parameters.Add(new SqlParameter("@DeviceType", devicetype));
                lSQLCmd.Parameters.Add(new SqlParameter("@IsMobiledevice", ismobiledevice));
                lSQLCmd.Parameters.Add(new SqlParameter("@fk_uid", fk_uid));
                lSQLCmd.Parameters.Add(new SqlParameter("@fk_rid", fk_rid));
                lSQLCmd.Parameters.Add(new SqlParameter("@FK_clientid", FK_clientid));
                lSQLCmd.Parameters.Add(new SqlParameter("@uniqueid", uniqueid));
                lSQLCmd.Connection = lSQLConn;
                lSQLCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ErrorLogs.LogErrorData(ex.StackTrace, ex.InnerException.ToString());

            }
            finally
            {
                lSQLCmd.Dispose();
                lSQLConn.Close();
            }
        }


    }
}