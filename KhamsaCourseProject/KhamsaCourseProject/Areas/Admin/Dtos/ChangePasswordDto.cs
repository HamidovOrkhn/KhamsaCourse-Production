using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Dtos
{
    public class ChangePasswordDto
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public class ChangePasswordDtoValidator : AbstractValidator<ChangePasswordDto>
        {
            public ChangePasswordDtoValidator()
            {
                RuleFor(a => a.Password).NotNull().WithMessage("Sahə doldurulmalıdır").MinimumLength(5).WithMessage("Minimum 5 xarakter").MaximumLength(200).WithMessage("Maximum 200 xarakter");
                RuleFor(a => a.ConfirmPassword)
                .NotNull().WithMessage("Sahə doldurulmalıdır")
                .MinimumLength(5).WithMessage("Minimum 5 xarakter")
                .MaximumLength(200).WithMessage("Maximum 200 xarakter")
                .Equal(x => x.ConfirmPassword).WithMessage("Şifrə təkrarı uyğunlaşmır"); ;
            }
        }
    }
}
