﻿using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
       IQueryable<Employee> GetEmployeeAddress(string address);
       IQueryable<Employee> SearchByName(String name);
    }
}
