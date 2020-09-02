using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Food
    {
        [Key]
        [Column(Order = 1)]
        public string UserName { get; set; }
        [Key]
        [Column(Order = 2)]
        public string NameFood { get; set; }
        public String Meal { get; set; }
        public int Amount { get; set; }
        public int Calories { get; set; }
        public string Nutrients { get; set; }
        public String Day { get; set; }
        public Food()
        {
            NameFood = "a";
        }
    }
    public enum EMeal { Breakfast, Lunch, Dinner, Snack };

}
