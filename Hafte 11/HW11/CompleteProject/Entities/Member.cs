
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CompleteProject.Entities;

public class Member:Person
{

    [DisplayName("نوع عضویت شخص")]
    public SubscriptionTypeEnum SubscriptionType { get; set; }

    [DisplayName("کتابهای در اختیار")]
    public ICollection<Book> Books { get; set; }

    [DisplayName("کتابخانه های عضو")]
    public ICollection<Library> Libraries { get; set; }

    [Required]
    public bool IsActive { get; set; } = true;
}