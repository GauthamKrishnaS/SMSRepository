﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMSProject.Models {
    public class Admin {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
