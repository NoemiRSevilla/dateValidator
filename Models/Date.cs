using System;

namespace dateValidator.Models
{
    public class Date
    {
        [FutureDate]
        public DateTime InputTime { get; set; }
    }
}