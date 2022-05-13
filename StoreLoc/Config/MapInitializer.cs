using AutoMapper;
using StoreLoc.APIData;
using StoreLoc.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreLoc.Config
{
    public class MapInitializer : Profile
    {
        public MapInitializer()
        {
            CreateMap<Province, ProvinceDTO>().ReverseMap();
            CreateMap<Province, CreateProvinceDTO>().ReverseMap();
            CreateMap<ShoppingCenter, ShoppingCenterDTO>().ReverseMap();
            CreateMap<ShoppingCenter, CreateShoppingCenterDTO>().ReverseMap();
            CreateMap<Store, StoreDTO>().ReverseMap();
            CreateMap<Store, CreateStoreDTO>().ReverseMap();
            CreateMap<APIUser, APIUserDTO>().ReverseMap();
            
        }
    }
}
