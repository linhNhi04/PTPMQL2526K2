using System.ComponentModel.DataAnnotations;
namespace buoi3.Models
{
    public class BMI
    {
        public string hoten { get; set; } // full name
        public double cannang { get; set; } // weight in kg
        public double chieucao { get; set; } // height in meters
        public double chisoBMI { get; set; } // BMI index
        public string ketqua { get; set; } // result category
    }
}