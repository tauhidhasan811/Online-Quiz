using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CreateMap
{
    public static class CreateMap<CLASS, CLASSDTO>
    {
        public static Mapper GetMap()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CLASS, CLASSDTO>().ReverseMap();
            });
            return new Mapper(config);
        }
    }
    public static class CreateMap<CLASS1, CLASS1DTO, CLASS2, CLASS2DTO>
    {
        public static Mapper GetMap()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CLASS1, CLASS1DTO>().ReverseMap();
                cfg.CreateMap<CLASS2,  CLASS2DTO>().ReverseMap();
            });
            return new Mapper(config);
        }
    }
}
