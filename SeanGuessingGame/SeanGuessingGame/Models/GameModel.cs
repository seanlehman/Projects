using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Added for models
using System.Linq;
using System.Web;

namespace SeanGuessingGame.Models
{
    public class GameModel
    {
        [Display(Name = "Enter your name")]  //Adds label to button
        [Required(ErrorMessage = "You must enter your name")] //Returns error msg if nothing entered in the dialog box
        [MinLength(2, ErrorMessage = "Name is too short")]
        [MaxLength(20, ErrorMessage = "Name is too long")]

        public string PlayerName { get; set; }  //Sets variable PlayerName properties

        [Display(Name = "Guess the number from 1-20")]
        [Required(ErrorMessage ="Guess is required")] //Returns error msg if nothing entered in dialog box
        [Range(1, 20, ErrorMessage = "Guess must be between 1 and 20")]

        public int Guess { get; set; }  //Sets variable Guess properties

        public override string ToString()  //Override to format the values
        {
            return $"{PlayerName} ({Guess})";  //Parentheses allows better visibility during debugging

        }
    }
}