//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoktorTbl
    {
        public int DoktorID { get; set; }
        public string DoktorAd { get; set; }
        public string DoktorSoyad { get; set; }
        public string DoktorTel { get; set; }
        public int IzinID { get; set; }
        public Nullable<int> BolumID { get; set; }
    
        public virtual BolumTbl BolumTbl { get; set; }
        public virtual IzinTbl IzinTbl { get; set; }
    }
}
