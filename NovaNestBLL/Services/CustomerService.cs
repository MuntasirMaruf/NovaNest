using AutoMapper;
using NovaNestBLL.DTOs;
using NovaNestDAL.EF;
using NovaNestDAL.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaNestBLL.Services
{
    public class CustomerService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDTO>();
                cfg.CreateMap<CustomerDTO, Customer>();
            });
            return new Mapper(config);
        }

        public static CustomerDTO Get(int id)
        {
            var userRepo = new UserRepo();
            var data = userRepo.Get(id);

            return GetMapper().Map<CustomerDTO>(data);
        }

        public static List<CustomerDTO> Get()
        {
            var userRepo = new UserRepo();
            var data = userRepo.Get();

            return GetMapper().Map<List<CustomerDTO>>(data);
        }

        public static void Create(CustomerDTO customer)
        {
            var userRepo = new UserRepo();
            userRepo.Create(GetMapper().Map<Customer>(customer));
        }
    }
}
