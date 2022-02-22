using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoursework.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Display(Name = "Марка")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Name { get; set; }
        [Display(Name = "Кузов")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Body { get; set; }
        [Display(Name = "Об'єм")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public double Volume { get; set; }
        [Display(Name = "Тип палива")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string FuelType { get; set; }
        [Display(Name = "Коробка передач")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Transmission { get; set; }
        [Display(Name = "Ціна")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public double Price { get; set; }
        [Display(Name = "Фото")]
        public string Photo { get; set; }
    }
}
