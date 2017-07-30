using System.ComponentModel.DataAnnotations;


namespace Child_Universe.Models.AccountModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Login { get; set; }


        [Required(ErrorMessage = "Обов'язкове поле")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}