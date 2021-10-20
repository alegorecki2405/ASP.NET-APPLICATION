using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class BirthDateFormModel
    {
        [Display(Name = "Birth Date")]
        public System.DateTime BirthDate { get; set; }

        [Display(Name = "Days since birth date")]
        public int DaysSinceBirth
        {
            get
            {
                return (System.DateTime.Now - BirthDate).Days;
            }
        }
    }
}
