using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Entities
{
    public class PlacementContract
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlacementContractID { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Location ID is required")]
        public int? LocationID { get; set; }

        #region Navigation Properties
        public virtual Location Locations { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
        #endregion
    }
}
