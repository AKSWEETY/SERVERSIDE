using System.ComponentModel.DataAnnotations;

namespace KadariWeek2M.Models
{
    public class LawnMowersmodel
    {
        //properties with annotations
        [Required] //makes the name field required
        public string?  Name { get; set; }
        public double  Area { get; set; }
        [Range (1000,10000, ErrorMessage = " Sft must be between 1000 to 100000")]
        public int  NumWeeks { get; set; }
        [Range (1, 20 , ErrorMessage="number of week in 1 and 20")]
        public double Quote { get; set; }
        //method to calculate

        public void Calculate()
        {
            //calculate the quote based on the area and number of weeks
            if (Area > 35000) { Quote = NumWeeks * 40; }
            else if ( Area > 25000) { Quote =NumWeeks*35;}
            else if (Area > 10000) { Quote = NumWeeks * 30; }
            else { Quote = NumWeeks * 25; }
        }

    }//end class
}//namespace
