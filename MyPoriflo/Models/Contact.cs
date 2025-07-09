using System.ComponentModel.DataAnnotations;

namespace MyPoriflo.Models
{
    public class Contact
    {


        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "الاسم مطلوب")]
        public string Name { get; set; }

        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        [EmailAddress(ErrorMessage = "البريد غير صحيح")]
        public string Email { get; set; }

        [Required(ErrorMessage = "رقم الهاتف مطلوب")]
        [Phone(ErrorMessage = "رقم الهاتف غير صحيح")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "الرسالة مطلوبة")]
        public string Message { get; set; }
    }
}
