using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Models
{
    public class Corporation
    {
        [Key]
        public int corp_no { get; set; }
        public string corp_name { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state_prov { get; set; }
        public string country { get; set; }
        public string mail_code { get; set; }
        public string phone_no { get; set; }
        public DateTime expr_dt { get; set; }
        public string corp_code { get; set; }




    }
}
