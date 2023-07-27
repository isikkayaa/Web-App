using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Project.Entities;
using Project.Models;

namespace Project
{
    public class AutoMapperConfig: Profile
    {


        public AutoMapperConfig()
        {
            CreateMap<User, UserViewModel>().ReverseMap();       /*userclassını userviewmodele cevirmeyi ögren,tersini de ögren*/
            CreateMap<User, CreateUserModel>().ReverseMap();
            CreateMap<User, EditUserModel>().ReverseMap();
        }
    }
}

 
