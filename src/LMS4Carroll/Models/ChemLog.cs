﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LMS4Carroll.Models
{
    public class ChemLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Log ID")]
        public int ChemLogId { get; set; }

        [Required]
        [ForeignKey("ChemInventory")]
        [Display(Name = "Inventroy ID")]
        public int? ChemInventoryId { get; set; }
        public virtual ChemInventory ChemInventory { get; set; }

        [Required]
        [Display(Name = "Qty Used")]
        public float QtyUsed { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date Created")]
        public DateTime DatetimeCreated { get; set; }

        [Required]
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }

    }
}
