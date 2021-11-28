using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Models
{
    public class StudentLessonSector : StudentBaseTypes
    {
        public class StudentLessonSectorValidator : AbstractValidator<StudentLessonSector>
        {
            public StudentLessonSectorValidator()
            {
                Include(new StudentBaseTypesValidator());
            }
        }
    }
}
