using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Entities
{
    public class Shift
    {
        public Shift()
        {
            Active = true;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShiftID { get; set; }

        [Required(ErrorMessage = "The placement contract id is required")]
        public int? PlacementContractID { get; set; }

        [Required(ErrorMessage = "The number of day of work is required")]
        public Byte? DayOfWeek { get; set; }

        [Required(ErrorMessage = "The time of start is required")]
        public TimeSpan? StartTime { get; set; }

        [Required(ErrorMessage = "The time of end is required")]
        public TimeSpan? EndTime { get; set; }

        [Required(ErrorMessage = "The number of employee is required")]
        public Byte? NumberOfEmployees { get; set; }

        public bool Active { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Notes { get; set; }

        #region Navigation Properties
        public virtual Location Locations { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        #endregion
    }
}
