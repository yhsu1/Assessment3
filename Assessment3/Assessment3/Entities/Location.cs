using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Entities
{
    public class Location
    {
        public Location()
        {
            Active = true;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationID { get; set; }

        [Required(ErrorMessage = "The name of location is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The name of street is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Street { get; set; }

        [Required(ErrorMessage = "The name of city is required")]
        [StringLength(30, MinimumLength = 3)]
        public string City { get; set; }

        [Required(ErrorMessage = "The province is required")]
        [StringLength(2)]
        public char? Province { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Contact { get; set; }

        [Required(ErrorMessage = "The phone number is required")]
        public string Phone { get; set; }

        public bool Active { get; set; }

        #region Navigation Properties
        public virtual ICollection<PlacementContract> PlacementContracts { get; set; }
        #endregion
    }
}
