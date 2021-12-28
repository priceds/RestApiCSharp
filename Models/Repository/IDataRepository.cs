using System;
using System.Collections.Generic;
using RestFull.Models;
namespace RestFull.Models.Repository
{
    public interface IDataRepository<Employee>
    {
        IEnumerable<Employee> GetAll();
        Employee Get(long id);
        void Add(Employee entity);
        void Update(Employee dbEntity, Employee entity);
        void Delete(Employee entity);


    }
}
