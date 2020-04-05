using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sacrament_final.Models
{
    public class Sacrament
    {
        public int SacramentId { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Speaker Topic")]
        public string SpeakerTopic { get; set; }

        [Required]
        [Display(Name = "Conduction Leader")]
        public string ConductingLeader { get; set; }

        [Required]
        [Display(Name = "Opening Song")]
        public string OpenignSong { get; set; }

        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Speaker One")]
        public string Speaker { get; set; }

        [Display(Name = "Speaker Two (Optional)")]
        public string SpeakerTwo { get; set; }

        [Display(Name = "Speaker Three (Optional)")]
        public string SpeakerThree { get; set; }

        [Display(Name = "Intermediat Hymn (Optional)")]
        public string IntermediateHymn { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

    }
}
