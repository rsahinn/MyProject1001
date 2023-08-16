using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
	public class WriterValidate : AbstractValidator<Writer>
	{
		public WriterValidate()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı ve soyadı kısmı boş geçilemez.");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapınız.");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterli veri girişi yapın.");
			RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harf içermelidir.");
			RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Şifre en az bir küçük harf içermelidir.");
			RuleFor(x => x.WriterPassword).Matches(@"[1-9]+").WithMessage("Şifre en az bir rakam  içermelidir.");
		}
	}
}
