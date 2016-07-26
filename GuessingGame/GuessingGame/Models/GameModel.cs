using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class GameModel  //Meta or Aspect programming style
    {  
        [Display(Name = "Enter your name")]  //Attribute
        [Required(ErrorMessage = "You must enter your name")]  //Makes the input be a name
        [MinLength(2, ErrorMessage = "Name is too short")]         
        [MaxLength(20, ErrorMessage = "Name is too long")]

        public string PlayerName { get; set;}

        [Display(Name = "What is your guess")]
        [Required(ErrorMessage ="Guess is required")] //Makes the input be a number
        [Range(1, 10, ErrorMessage = "Guess must be between 1 and 10")] //Limits range of guessing allowed

        public int Guess { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} ({Guess})";
        }
    }
}