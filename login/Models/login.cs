//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class login
    {
        public int Id { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage ="This Field is Requiered.")]
        public string Name { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This Field is Requiered.")]
        public string password { get; set; }
        public string loginerrormsg { get; set; }

    }
}
