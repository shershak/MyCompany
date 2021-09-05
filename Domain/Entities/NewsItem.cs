using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class NewsItem : EntityBase
    {
        [Required(ErrorMessage = "Напишите заголовок новости")]
        [Display(Name = "Заголовок новости")]
        public override string Title { get; set; }

        [Required(ErrorMessage = "Напишите краткое содержание новости")]
        [Display(Name = "Краткое содержание новости")]
        public override string Subtitle { get; set; }

        [Required(ErrorMessage = "Напишите полное содержание новости")]
        [Display(Name = "Полное содержание новости")]
        public override string Text { get; set; }

        [Required(ErrorMessage = "Укажите Ваше имя")]
        [Display(Name = "Ваше имя")]
        public override string Name { get; set; }

        [Required(ErrorMessage = "Укажите Ваш Email")]
        [Display(Name = "Ваш Email для обратной связи")]
        public override string Email { get; set; }
    }
}
