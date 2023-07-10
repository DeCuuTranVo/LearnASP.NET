using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

class LecturerMetaData {

    // Limit the length of input string to 40 character
    [StringLength(50)]
    // Set labels of fields of table
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;
}

[ModelMetadataType(typeof(Lecturer))]
public partial class Lecturer{

}