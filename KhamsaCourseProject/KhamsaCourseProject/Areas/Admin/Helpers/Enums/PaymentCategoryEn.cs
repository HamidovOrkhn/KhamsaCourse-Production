using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Helpers.Enums
{
    public class PaymentCategoryEn
    {
        public enum PaymentCategories
        {
            İşci_Çıxışı = 1,
            Nəşriyyatdan_Gəlir,
            Əlavə_Gəlir,
            Əlavə_Xərc,
            Ofis_Xərc,
            Maaş,
            İşci_Alışı,
            İmtahandan_Gəlir,
            Digər,
            Pul_Çıxışı,
            Tələbədən_Gəlir
        }
        public enum PaymentTypes
        {
            Gəlir = 1,
            Zərər
        }
        public static string ReturnCategoryName(int id)
        {
            switch (id)
            {
                case (int)PaymentCategories.İşci_Çıxışı:
                    return "İşci Çıxışı";
                case (int)PaymentCategories.Nəşriyyatdan_Gəlir:
                    return "Nəşriyyatdan Gəlir";
                case (int)PaymentCategories.Əlavə_Gəlir:
                    return "Əlavə Gəlir";
                case (int)PaymentCategories.Əlavə_Xərc:
                    return "Əlavə Xərc";
                case (int)PaymentCategories.Ofis_Xərc:
                    return "Ofis Xərc";
                case (int)PaymentCategories.Maaş:
                    return "Maaş";
                case (int)PaymentCategories.İşci_Alışı:
                    return "İşci Alışı";
                case (int)PaymentCategories.İmtahandan_Gəlir:
                    return "İmtahandan Gəlir";
                case (int)PaymentCategories.Digər:
                    return "Digər";
                case (int)PaymentCategories.Pul_Çıxışı:
                    return "Pul Çıxışı";
                case (int)PaymentCategories.Tələbədən_Gəlir:
                    return "Tələbədən Gəlir";
                default:
                    return "Undefined";
            }
        }
        public static string ReturnTypeName(int id)
        {
            switch (id)
            {
                case (int)PaymentTypes.Gəlir:
                    return "Gəlir";
                case (int)PaymentTypes.Zərər:
                    return "Zərər";
                default:
                    return "Undefined";
            }
        }

    }
}
