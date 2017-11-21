using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Account
/// </summary>
public class Account
{

        public string code { get; set; }
        public string pass { get; set; }
        public string name { get; set; }
        public long current { get; set; }
        public override string ToString()
        {
         return this.code + "#" + this.pass + "#" +this.name+"#"+ this.current;
        }
}