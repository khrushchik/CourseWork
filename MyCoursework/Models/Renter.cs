using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoursework.Models
{
    public class Renter
    {
        public int Id { get; set; }
        [Display(Name = "Ім'я")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Name { get; set; }
        [Display(Name = "Прізвище")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Surname { get; set; }
        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Phone { get; set; }
        [Display(Name = "Стаж")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Experience { get; set; }
        [Display(Name = "Обраний авто")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int CarId { get; set; }
        [Display(Name = "Додаткова інформація (необов'язково)")]
        public string Info { get; set; }
        public virtual Car Car { get; set; }
    }
}
