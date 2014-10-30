using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Entities
{
    public class Schedule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleID { get; set; }

        public DateTime? Day { get; set; }

        [Required(ErrorMessage = "The shift ID is required")]
        public int? ShiftID { get; set; }

        [Required(ErrorMessage = "The employee ID is required")]
        public int? EmployeeID { get; set; }


        #region Navigation Properties
        public virtual Shift Shifts { get; set; }
        public virtual Employee Employees { get; set; }
        #endregion
    }
}
