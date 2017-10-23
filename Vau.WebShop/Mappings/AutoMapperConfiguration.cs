
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vau.Model.Models;
using Vau.WebShop.Models;

namespace Vau.WebShop.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //// cách config tĩnh này đã bỏ từ bản 4.2
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Post, PostViewModel>();
            //    cfg.CreateMap<PostCategory, PostCategoryViewModel>();

            //    cfg.CreateMap<Tag, TagViewModel>();
            //});

            //IMapper mapper = config.CreateMapper();
        }
    }
}