using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
   public  class Student
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Stream { get; set; }
       

    }
}
