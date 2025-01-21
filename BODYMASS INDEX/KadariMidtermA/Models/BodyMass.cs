using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace KadariMidtermA.Models
{
    //created by Kadari
    public class BodyMass
    {
        //Name property
        [Required(ErrorMessage ="Please enter your name field is required.")]
        [Display(Name="Please enter your Name ")]
        public string? Name {  get; set; }
        //Gender property
        [Required(ErrorMessage = "Please select your gender field is required.")]
        [Display(Name="Please select gender ")]
        public string? Gender {  get; set; }

        //list for gender dropdown
        public List<SelectListItem> Genderlist = new List<SelectListItem>
        {
            new SelectListItem{ Value="",Text=""},
            new SelectListItem{ Value="Male",Text="Male"},
            new SelectListItem{ Value="Female",Text="Female"},
             new SelectListItem{ Value="Unspecified",Text="Unspecified"},
        };

        // Weight property which should be in the range of 30 and 450

        [Required]
        [Display(Name="Please eneter your weigth in pounds:")]
        [Range(30,450,ErrorMessage ="Weight must be in 30 and 450 pounds")]
        public double Weight {  get; set; }

        //height property set to range of 24 and 90 inches
        [Required]
        [Display(Name = "Please eneter your height in inches:")]
        [Range(20, 90, ErrorMessage = "Height must be in 24 and 90 inches")]
        public double Height {  get; set; }

        // property for checkbox

        [Display(Name="Please select to display credits")]
        public bool Credit {  get; set; }

        public double Bodymass {  get; set; }
        public string? Studentid {  get; set; }
        public string? Namecreated {  get; set; }

        public string? Result {  get; set; }

        public void Calculatebodymass()// METHOD TO CALCULATE BODYMASS
        {
            Bodymass = 0;
            Bodymass = Bodymass + (Weight / (Height*Height) )* 703;
            Bodymass = Math.Round(Bodymass, 4);

             Result="";

            if (Bodymass < 18.5) // condition for under weight
            {
               Result = " Your BMI " +Bodymass+ " indicates Underweight Condition";
            }
            else if (Bodymass >= 18.5 && Bodymass <= 24.9) // condition for normal weight
            {
                Result = " Your BMI " + Bodymass + " Normalweight Condition";
            }
            else if (Bodymass >= 25 && Bodymass <= 29.9) // condition for overweight
            {
                Result = " Your BMI " + Bodymass + " Overweight Condition";
            }
            else if (Bodymass >= 30 && Bodymass <= 34.9)// condition for class I obese weight
            {
                Result = " Your BMI " + Bodymass + " class I obeseCondition";
            }
            else if (Bodymass >= 35 && Bodymass <= 39.9)// condition for class II obese weight
            {
                Result = " Your BMI " + Bodymass + " class II Obese Condition";
            }
            else if( Bodymass > 40)// condition for class III obese weight
        {
                Result = " Your BMI of" + Bodymass + "class III obese Condition";
            }
            if (Credit)// if checkbox is checked name and id id displayed
            {
                Namecreated = "Akshaya Kadari";
                Studentid = "700-756-009";
            }
        }

    }
}
