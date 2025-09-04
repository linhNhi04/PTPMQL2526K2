namespace DemoMVC.Models
{
    public class Person 
    {
        public string FullName { get; set ;}
        public int Date { get; set; }
        public int age 
        {
            get
            {
                int NamNay = DateTime.Now.Year;
                return NamNay - Date;
            }
        }
    }
}