using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class MessageItem : EntityBase
    {
        [Required(ErrorMessage = "Напишите тему сообщения")]
        [Display(Name = "Тема")]
        public override string Title { get; set; }

        [Required(ErrorMessage = "Напишите ваше имя")]
        [Display(Name = "Ваше имя")]
        public override string Name { get; set; }

        [Required(ErrorMessage = "Напишите ваш email")]
        [Display(Name = "Ваш Email для обратной связи")]
        public override string Email { get; set; }

        [Required(ErrorMessage = "Напишите текст сообщения")]
        [Display(Name = "Сообщение")]
        public override string Text { get; set; }
    }
}
