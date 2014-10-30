using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Entities
{
    public class EmployeeSkill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeSkillID { get; set; }

        [Required(ErrorMessage = "Employee ID is required")]
        public int? EmployeeID { get; set; }

        [Required(ErrorMessage = "Skill ID is required")]
        public int? SkillID { get; set; }

        [Required(ErrorMessage = "Level ID is required")]
        public int? Level { get; set; }

        public int YearsOfExperience { get; set; }

        #region Navigation Properties
        public virtual Skill Skills { get; set; }
        public virtual Employee Employees { get; set; }
        #endregion
    }
}
