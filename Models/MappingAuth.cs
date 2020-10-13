using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    //public class MappingAuth : Profile
    //{
    //    public MappingAuth()
    //    {

    //        #region Page

    //        CreateMap<Page, PageVM>();
                
    //        CreateMap<PageVM, Page>();

    //        #endregion
            
            
    //        #region RolePageMap

    //        CreateMap<RolePageMap, RolePageVM>()
    //            .ForMember(
    //                dest => dest.DepartmentName,
    //                opt => opt.MapFrom(src => src.Department.Name)
    //            );
    //        CreateMap<RolePageVM, RolePageMap>();
    //        #endregion

    //    }
    //}
}
