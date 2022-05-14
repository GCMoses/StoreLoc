using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.DTO_s
{
    public class CreateProvinceDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Province Name Is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Province Name Is Too Long")]
        public string ShortName { get; set; }
    }

    public class UpdateProvinceDTO : CreateProvinceDTO
    {
        public IList<CreateShoppingCenterDTO> ShoppingCenters { get; set; }
        public IList<CreateStoreDTO> Stores { get; set; }
    }

    public class ProvinceDTO : CreateProvinceDTO
    {
        public int Id { get; set; }
        public IList<ShoppingCenterDTO> ShoppingCenters { get; set; }
        public IList<StoreDTO> Stores { get; set; }
    }
}


