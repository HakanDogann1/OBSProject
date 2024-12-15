using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSProject.BusinessLayer.AutoMapper
{
    public class ObjectMapping
    {
        public static Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(opt =>
            {
                opt.AddProfile<OBSProjectMapping>();
            });
            return config.CreateMapper();
        });

        public static IMapper mapper => lazy.Value;
    }
}
