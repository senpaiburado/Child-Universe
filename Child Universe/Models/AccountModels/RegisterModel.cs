using Child_Universe.Models.OwnAttributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Child_Universe.Models.AccountModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Обов'язкове поле")]
        [DisplayName("Ім'я")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [DisplayName("Призвіще")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [DisplayName("Електронна пошта")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Електронна пошта введена некоректно")]
        public string EmailAdress { get; set; }

        [DisplayName("Номер телефону")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [DisplayName("Логін")]
        [MinLength(5, ErrorMessage = "Логін повинен містити не менше 5 символів.")]
        [MaxLength(14, ErrorMessage = "Логін повинен містити не більше 14 символів.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Пароль повинен містити тільки букви латинського алфавіту і цифри.")]
        [UniqueLogin("Password")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [DisplayName("Пароль")]
        [DataType(dataType: DataType.Password)]
        [MinLength(8, ErrorMessage = "Пароль повинен містити не менше 8 символів.")]
        [MaxLength(18, ErrorMessage = "Пароль повинен містити не більше 18 символів.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Пароль повинен містити тільки букви латинського алфавіту і цифри.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [DisplayName("Підтвердіть пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Паролі не співпадають!")]
        public string ConfirmPassword { get; set; }
    }
}