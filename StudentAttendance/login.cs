//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentAttendance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class login
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Please Provide User Name",AllowEmptyStrings =false) ]
        public string username { get; set; }
        [Required(ErrorMessage = "Please Provide Password", AllowEmptyStrings = false)]
        public string password { get; set; }
        public string role { get; set; }
    }
}
