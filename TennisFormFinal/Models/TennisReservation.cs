

using System;

using System.ComponentModel.DataAnnotations;

namespace TennisFormFinal.Models
{



    public class TennisReservation
    {
        [Key]
        public int ReservationId { get; set; }
        public String FieldName { get; set; }
        [DateAttribute()]
        public DateTime ReservationTime { get; set; }
        public String MatchType { get; set; }




    }

    

    public class DateAttribute : RangeAttribute
    {
        public DateAttribute()
          : base(typeof(DateTime), DateTime.Now.ToShortDateString(), DateTime.Now.AddYears(2).ToShortDateString()) { }
    }

}
