using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.DTO_s
{
    public class CreateShoppingCenterDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "ShoppingCenter Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Address Name Is Too Long")]
        public string Address { get; set; }

        [StringLength(maximumLength: 11, ErrorMessage = "Phone number exceed 11 digits!")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }
        public string OperationalHours { get; set; }

        [Required]
        public int ProvinceId { get; set; }
    }

    public class UpdateShoppingCenterDTO : CreateShoppingCenterDTO
    {

    }

    public class ShoppingCenterDTO : CreateShoppingCenterDTO
    {
        public int Id { get; set; }
        public ProvinceDTO Province { get; set; }
    }

}