using Analytics.Helpers.Utility;
using Analytics.Models;
//using Analytics.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
//using System.Data.Entity.Core.Objects;
//using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
//using EntityFramework.Extensions;
using System.Net;
using System.IO;
namespace Analytics.Helpers.BO
{

    public class DataInsertionBO
    {
        shortenURLEntities dc = new shortenURLEntities();
        SqlConnection lSQLConn = null;
        SqlCommand lSQLCmd = new SqlCommand();
        string connStr = "";
        public void InsertUIDdata(int fk_rid, int? fk_clientid, string referencenumber, string longurl, string mobilenumber)
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
        public void InsertRIDdata(string referencenumber, string pwd, int clientid)
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
        public void InsertShortUrldata1(string ipv4, string ipv6, string browser, string browser_version, string city, string Region, string country, string countrycode, string req_url, string useragent, string hostname, string devicetype, string ismobiledevice, int? fk_uid, int? fk_rid, int? FK_clientid)
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
                //lSQLCmd.Parameters.Add(new SqlParameter("@uniqueid", uniqueid));
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


        public void InsertShortUrldata(string ipv4, string ipv6, string ipnum, string browser, string browser_version, string req_url, string useragent, string hostname, string latitude,string longitude, string ismobiledevice, int? fk_uid, int? fk_rid, int? FK_clientid,string CookieValue,string MobileNumber)
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
                lSQLCmd.Parameters.Add(new SqlParameter("@ipnum", ipnum));
                lSQLCmd.Parameters.Add(new SqlParameter("@browser", browser));
                lSQLCmd.Parameters.Add(new SqlParameter("@browser_version", browser_version));
                lSQLCmd.Parameters.Add(new SqlParameter("@latitude", latitude));
                lSQLCmd.Parameters.Add(new SqlParameter("@longitude", longitude));

                //lSQLCmd.Parameters.Add(new SqlParameter("@Region", Region));
                //lSQLCmd.Parameters.Add(new SqlParameter("@city", city));
                //lSQLCmd.Parameters.Add(new SqlParameter("@Region", Region));
                //lSQLCmd.Parameters.Add(new SqlParameter("@country", country));
                //lSQLCmd.Parameters.Add(new SqlParameter("@countrycode", countrycode));
                lSQLCmd.Parameters.Add(new SqlParameter("@req_url", req_url));
                lSQLCmd.Parameters.Add(new SqlParameter("@useragent", useragent));
                lSQLCmd.Parameters.Add(new SqlParameter("@hostname", hostname));
                //lSQLCmd.Parameters.Add(new SqlParameter("@DeviceType", devicetype));
                lSQLCmd.Parameters.Add(new SqlParameter("@IsMobiledevice", ismobiledevice));
                lSQLCmd.Parameters.Add(new SqlParameter("@fk_uid", fk_uid));
                lSQLCmd.Parameters.Add(new SqlParameter("@fk_rid", fk_rid));
                lSQLCmd.Parameters.Add(new SqlParameter("@FK_clientid", FK_clientid));
                //lSQLCmd.Parameters.Add(new SqlParameter("@uniqueid", uniqueid));
                lSQLCmd.Parameters.Add(new SqlParameter("@cookievalue", CookieValue));
                lSQLCmd.Parameters.Add(new SqlParameter("@mobilenumber", MobileNumber));
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

        public void UpdateCityCountry(CountryCityModel obj)
        {
            try
            {
                //using (var dc = new shortenURLEntities())
                //{

                //    dc.SHORTURLDATAs.Where(x => x.PK_Shorturl == obj.pk_shorturl_id).Update(y => new SHORTURLDATA { 
                //City = obj.City, Region = obj.Region, Country = obj.Country, CountryCode = obj.CountryCode, PostalCode = obj.PostalCode, 
                //Latitude = obj.latitude, Longitude = obj.longitude, MetroCode = obj.metro_code, FK_City_Master_id = obj.fk_city_master_id });

                 //}
                var shorturl_record = dc.SHORTURLDATAs.SingleOrDefault(x => x.PK_Shorturl == obj.pk_shorturl_id);
                if(shorturl_record!=null)
                {
                   shorturl_record.City = obj.City;
                    shorturl_record.Region = obj.Region;
                    shorturl_record.Country = obj.Country;
                    shorturl_record.CountryCode = obj.CountryCode;
                    shorturl_record.PostalCode = obj.PostalCode;
                    shorturl_record.Latitude = obj.latitude;
                    shorturl_record.Longitude = obj.longitude;
                    shorturl_record.MetroCode = obj.metro_code;
                    shorturl_record.FK_City_Master_id=obj.fk_city_master_id;
                    dc.SaveChanges();
                }
            }
            catch (AggregateException e)
            {

            }
        }

        public void UpdateRowid(long? rowid)
        {
            using (var dc = new shortenURLEntities())
            {
                var res = dc.tmp_rownum_update.SingleOrDefault(x => x.PK_RowUpdate_ID == 1);
                if(res!=null)
                {
                    res.row_update = rowid;
                    dc.SaveChanges();
                }
               // dc.tmp_rownum_update.Where(x => x.PK_RowUpdate_ID == 1).Update(y => new tmp_rownum_update { row_update = rowid });
            }

        }
        public List<CountryCityModel> GetDataForNotFoundIPS(List<List_IP> ips)
        {
            List<List_IP> NotFoundIps = new List<List_IP>();
            List<CountryCityModel> freegeo_Table_Data = (from f in dc.freeGeoipDatas
                                                         //.AsNoTracking()
                                                         .AsEnumerable()
                                                         join i in ips on f.ip_num equals i.ipnum
                                                         where i.ipnum == f.ip_num
                                                         select new CountryCityModel()
                                                         {
                                                             ipnum=i.ipnum,
                                                             Country = f.Country,
                                                             CountryCode = f.CountryCode,
                                                             City = f.City,
                                                             Region = f.Region,
                                                             PostalCode = f.PostalCode,
                                                             latitude = f.Latitude,
                                                             longitude = f.Longitude,
                                                             metro_code = f.MetroCode,
                                                             pk_shorturl_id = i.pk_shorturl_id
                                                         }).ToList();
            if(freegeo_Table_Data.Count!=0)
            {
                if (freegeo_Table_Data.Count != ips.Count)
                {
                    NotFoundIps = ips.Where(p => !freegeo_Table_Data.Any(p2 => p2.ipnum == p.ipnum)).ToList();
                }
                //foreach(CountryCityModel obj in freegeo_Table_Data)
                //{
                //    UpdateCityCountry(obj);
                //}
            }
            else
            {
                NotFoundIps = ips;
            }
            if(NotFoundIps.Count!=0)
            {
                foreach (List_IP i in NotFoundIps)
                {
                   CountryCityModel obj= GetDataFromfreegeoip(i);
                   freegeo_Table_Data.Add(obj);
                }
            }
            return freegeo_Table_Data;
        }

        public CountryCityModel GetDataFromfreegeoip(List_IP l)
        {

            string jsonstring = ""; string url = "";
            CountryCityModel obj = new CountryCityModel();
            WebClient client = new WebClient();
            try
            {
                url = "http://freegeoip.net/json/" + l.ipaddress;
                jsonstring = client.DownloadString(url);
                if (jsonstring != "")
                {
                    dynamic dynObj = JsonConvert.DeserializeObject(jsonstring);

                    obj.City = dynObj.city;
                    obj.Region = dynObj.region_name;
                    // obj.region_code = dynObj.region_code;
                    obj.Country = dynObj.country_name;
                    obj.CountryCode = dynObj.country_code;
                    obj.PostalCode = dynObj.zip_code;
                    // obj.time_zone = dynObj.time_zone;
                    obj.latitude = dynObj.latitude;
                    obj.longitude = dynObj.longitude;
                    obj.metro_code = dynObj.metro_code;
                    //obj.accuracy_radius = "";
                 }
                obj.pk_shorturl_id = l.pk_shorturl_id;
              //var res=  dc.SHORTURLDATAs.Where(x => x.PK_Shorturl == l.pk_shorturl_id).SingleOrDefault();
                
              //      res.City = obj.City;
              //      res.Region = obj.Region;
              //      res.Country = obj.Country;
              //      res.CountryCode = obj.CountryCode;
              //      res.PostalCode = obj.PostalCode;
              //      res.Latitude = obj.latitude;
              //      res.Longitude = obj.longitude;
              //      res.MetroCode = obj.metro_code;
              //      dc.SaveChanges();
               // UpdateCityCountry(obj);
                freeGeoipData objf = dc.freeGeoipDatas.SingleOrDefault(x => x.Ipv4 == l.ipaddress);
                if (objf == null)
                {
                    freeGeoipData f = new freeGeoipData();
                    f.Ipv4 = l.ipaddress;
                    f.ip_num = l.ipnum;
                    f.City = obj.City;
                    f.Region = obj.Region;
                    f.Country = obj.Country;
                    f.CountryCode = obj.CountryCode;
                    f.PostalCode = obj.PostalCode;
                    f.Latitude = obj.latitude;
                    f.Longitude = obj.longitude;
                    f.MetroCode = obj.metro_code;
                    dc.freeGeoipDatas.Add(f);
                    dc.SaveChanges();
                }
                    return obj;
                
            }
            catch (Exception ex)
            {
                url = "http://geoip.nekudo.com/api/" + l.ipaddress;
                jsonstring = client.DownloadString(url);
                if (jsonstring != "")
                {
                    dynamic dynObj = JsonConvert.DeserializeObject(jsonstring);

                    obj.City = dynObj.city;
                    obj.Region = dynObj.region_name;
                    // obj.region_code = dynObj.region_code;
                    obj.Country = dynObj.country_name;
                    obj.CountryCode = dynObj.country_code;
                    obj.PostalCode = dynObj.zip_code;
                    // obj.time_zone = dynObj.time_zone;
                    obj.latitude = dynObj.latitude;
                    obj.longitude = dynObj.longitude;
                    obj.metro_code = dynObj.metro_code;
                    //obj.accuracy_radius = "";
                }
                obj.pk_shorturl_id = l.pk_shorturl_id;
                //UpdateCityCountry(obj);
                //var res = dc.SHORTURLDATAs.Where(x => x.PK_Shorturl == l.pk_shorturl_id).SingleOrDefault();

                //res.City = obj.City;
                //res.Region = obj.Region;
                //res.Country = obj.Country;
                //res.CountryCode = obj.CountryCode;
                //res.PostalCode = obj.PostalCode;
                //res.Latitude = obj.latitude;
                //res.Longitude = obj.longitude;
                //res.MetroCode = obj.metro_code;
                //dc.SaveChanges();
                 freeGeoipData objf = dc.freeGeoipDatas.SingleOrDefault(x => x.Ipv4 == l.ipaddress);
                 if (objf == null)
                 {
                     freeGeoipData f = new freeGeoipData();
                     f.Ipv4 = l.ipaddress;
                     f.ip_num = l.ipnum;
                     f.City = obj.City;
                     f.Region = obj.Region;
                     f.Country = obj.Country;
                     f.CountryCode = obj.CountryCode;
                     f.PostalCode = obj.PostalCode;
                     f.Latitude = obj.latitude;
                     f.Longitude = obj.longitude;
                     f.MetroCode = obj.metro_code;
                     dc.freeGeoipDatas.Add(f);
                     dc.SaveChanges();
                 }
                return obj;
            }
        }

    }
}