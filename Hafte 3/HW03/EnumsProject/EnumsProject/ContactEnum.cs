using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;


public enum ContactType
{
    [Display(Name ="Payamak")]
    SMS = 1,
    [Display(Name = "Poste Electronic")]
    Email = 2
}
