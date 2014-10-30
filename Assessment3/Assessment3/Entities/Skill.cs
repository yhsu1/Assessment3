using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Entities
{
    public class Skill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SkillID { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, MinimumLength = 3)]
        public string Description { get; set; }

        public bool RequiresTicket { get; set; }

        #region Navigation Properties
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        #endregion
    }
}
