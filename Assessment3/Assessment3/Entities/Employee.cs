using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Entities
{
    public class Employee
    {
        public Employee()
        {
            Active = true;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Home phone is required")]
        [StringLength(12)]
        public string HomePhone { get; set; }

        public bool Active { get; set; }

        #region Navigation Properties
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        #endregion
    }
}
