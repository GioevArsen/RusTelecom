using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace RusTelecom.Models
{
    public class Contract
    {
        static int unicId = 0;
        public int Id { get; }

        [Required(ErrorMessage = "Пожалуйста, укажите фамилию человека, на которого оформляется договор")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Пожалуйста, укажите настоящую фамилию")]
        [RegularExpression("^[A-Z].*", ErrorMessage = "Фамилия должна начинаться с большой буквы")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите имя человека, на которого оформляется договор")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Пожалуйста, укажите настоящее имя")]
        [RegularExpression("^[A-Z].*", ErrorMessage = "Имя должно начинаться с большой буквы")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите отчество человека, на которого оформляется договор")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Пожалуйста, укажите настоящее отчество")]
        [RegularExpression("^[A-Z].*", ErrorMessage = "Отчество должно начинаться с большой буквы")]
        public string Secondname { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите IP адрес человека, на которого оформляется договор")]
        [RegularExpression("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$", ErrorMessage = "Пожалуйсте, введите действительный IP address")]
        public string IP { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите тип услуги")]
        public string Service {  get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите текущую дату")]
        public DateTime Date { get; set; }

        public Contract(string lastname, string firstname, string secondname, string ip, string service, DateTime date)
        {
            unicId++;
            Id = unicId;
            Lastname = lastname;
            Firstname = firstname;
            Secondname = secondname;
            IP = ip;
            Service = service;
            Date = date;
        }

        public Contract(int id, string lastname, string firstname, string secondname, string ip, string service, DateTime date)
        {
            Id = id;
            Lastname = lastname;
            Firstname = firstname;
            Secondname = secondname;
            IP = ip;
            Service = service;
            Date = date;
        }
    }
}
