//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1804_04
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kullanici
    {
        public int Kullanıcı_No { get; set; }
        public string Kullanıcı_Adı_Soyadı { get; set; }
        public string Kullanıcı_Sirket { get; set; }
        public string Kullanıcı_Tc { get; set; }
        public string Kullanıcı_Mail { get; set; }
        public string Kullanıcı_Telefon { get; set; }
        public Nullable<int> Kullanıcı_Araç_No { get; set; }
    
        public virtual Araclar Araclar { get; set; }
        public virtual Kayit Kayit { get; set; }
    }
}