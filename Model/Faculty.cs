using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
   public class Faculty
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Subject { get; set; }
        public string Shift { get; set; }
        



    }
}
