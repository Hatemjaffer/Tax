//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grad_Tax.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int ID_User { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PermissionType { get; set; }
        public Nullable<int> id_State { get; set; }
    }
}
