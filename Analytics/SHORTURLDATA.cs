//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Analytics
{
    using System;
    using System.Collections.Generic;
    
    public partial class SHORTURLDATA
    {
        public int PK_Shorturl { get; set; }
        public string Ipv4 { get; set; }
        public string Ipv6 { get; set; }
        public string Browser { get; set; }
        public string Browser_version { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Req_url { get; set; }
        public string Hostname { get; set; }
        public string DeviceType { get; set; }
        public string UserAgent { get; set; }
        public string IsMobileDevice { get; set; }
        public string Region { get; set; }
        public Nullable<int> FK_Uid { get; set; }
        public Nullable<int> FK_RID { get; set; }
        public Nullable<int> FK_ClientID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> ip_num { get; set; }
        public string PostalCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string MetroCode { get; set; }
        public Nullable<int> FK_City_Master_id { get; set; }
    
        public virtual RIDDATA RIDDATA { get; set; }
        public virtual SHORTURLDATA SHORTURLDATA1 { get; set; }
        public virtual SHORTURLDATA SHORTURLDATA2 { get; set; }
        public virtual UIDDATA UIDDATA { get; set; }
        public virtual Client Client { get; set; }
    }
}
