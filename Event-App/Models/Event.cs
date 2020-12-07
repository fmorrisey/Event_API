﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Event_App.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [ForeignKey("IdentityUser")]
        public int IdentityUserId { get; set; }

        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [ForeignKey("Address")]
        public string Venue { get; set; }

        [ForeignKey("Interest")]
        public int InterestId { get; set; }

        [Display(Name = "Event Date")]
        [DisplayFormat(DataFormatString = "{0:MMM dd ddd h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? EventDate { get; set; }

        [Display(Name = "Event Description")]
        public string EventDescription { get; set; }

        public bool IsPrivate { get; set; }

        public bool IsVirtual { get; set; }

        [NotMapped]
        public List<Interest> interests { get; set; }
        public List<Event> Events { get; set; }



    }
}
