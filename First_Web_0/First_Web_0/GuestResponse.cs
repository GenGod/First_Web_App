using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace First_Web_0
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Пожалуйста укажите Ваше имя.")]
        public String name { get; set; }
        [Required(ErrorMessage ="Пожалуйста, укажите Ваш электронный адрес.")]
        public String email { get; set; }
        [Required(ErrorMessage ="Пожалуйста, укажите Ваш телефон.")]
        public String phone { get; set; }
        [Required(ErrorMessage ="Пожалуйста, укажите, придёте ли вы.")]
        public bool? WillAttend { get; set; }
    }
}