using CounterCalories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        static int i = 0;
        public User()
        {
            UserName = i.ToString();
            i++;
            Name = "";
            Password = "";
            BirthYear = 1000;
            Height = 0;
            Weight = 0;
            GramsToLose = 0;
            Gender = false;
            ActivityLevel = 0;
         
            


        }
        [Key]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int BirthYear { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int GramsToLose { get; set; }
        public Boolean Gender { get; set; }
        public EActivityLevel ActivityLevel { get; set; }
        public User Clone()
        {
            return new User()
            {
                UserName = UserName,
                Name = Name,
                Password = Password,
                BirthYear = BirthYear,
                Height = Height,
                Weight = Weight,
                GramsToLose = GramsToLose,
                Gender = Gender,
                ActivityLevel = ActivityLevel,
            };
        }

    }
    
    public enum EActivityLevel { Sedentary, LightlyActive, Moderatetely, VeryActive, ExtraActive };


}
