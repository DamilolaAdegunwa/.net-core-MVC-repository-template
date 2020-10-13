using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GRA.Data.Base;
using GRA.Data;

namespace GRA.Models
{
    public class GraGGUP : BaseModel
    {
        public int GraPersonId { get; set; }

        [ForeignKey(nameof(GraPersonId))] 
        public GraPerson GraPerson { get; set; }


        public int? GraGGUPEntryInfoId { get; set; }

        [ForeignKey(nameof(GraGGUPEntryInfoId))]
        public GraGGUPEntryInfo GraGGUPEntryInfo { get; set; }


        public int? GraGGUPExclusionId { get; set; }

        [ForeignKey(nameof(GraGGUPExclusionId))]
        public GraGGUPExclusion GraGGUPExclusion { get; set; }


        public int? GraGGUPSuspensionId { get; set; }

        [ForeignKey(nameof(GraGGUPSuspensionId))]
        public GraGGUPSuspension GraGGUPSuspension { get; set; }


        public int? GraGGUPSpecializationId { get; set; }

        [ForeignKey(nameof(GraGGUPSpecializationId))]
        public GraGGUPSpecialization GraGGUPSpecialization { get; set; }


        public int? GraGGUPHelpFormId { get; set; }

        [ForeignKey(nameof(GraGGUPHelpFormId))]
        public GraGGUPHelpForm GraGGUPHelpForm { get; set; }
    }
}