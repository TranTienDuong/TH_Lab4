using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên

        [Required(ErrorMessage = "Họ Tên không được để trống!")]
        [DisplayName("Họ và Tên ")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên tối thiểu 4 ký tự, tối đa 100 ký tự")]
        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [Display(Name = "Địa chỉ Email")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$", ErrorMessage = "Email không hợp lệ.")]
        public string? Email { get; set; } //Email

        [Required(ErrorMessage = "Password không được để trống!")]
        [Display(Name = "Mật khẩu")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Độ dài mật khẩu phải có ít nhất 8 kí tự")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,}$", ErrorMessage = "Mật khẩu phải có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        public string? Password { get; set; }//Mật khẩu

        [Required(ErrorMessage = "Hãy chọn ít nhất một chuyên ngành!")]
        [Display(Name = "Ngành học")]
        public Branch? Branch { get; set; }//Ngành học

        [Required(ErrorMessage = "Hãy chọn ít nhất một giới tính của bạn!")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }//Giới tính

        [Required]
        [Display(Name = "Hệ chính quy")]
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }//Địa chỉ

        [Required(ErrorMessage = "Hãy nhập ngày sinh")]
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Required(ErrorMessage = "Điểm không được để trống")]
        [Display(Name = "Điểm")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải là chữ số thập phân trong khoảng từ 0,0 đến 10,0!")]
        public Double? Diem { get; set; } //Điểm
    }
}
