//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginPage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required(ErrorMessage ="Kullan�c� Kodu", AllowEmptyStrings =false)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Kullan�c� �ifresi", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
    }
}
