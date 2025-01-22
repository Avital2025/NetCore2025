using Microsoft.EntityFrameworkCore;
using Queue_management_system.Service.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Queue_management_system
{
    public class DataContext:DbContext 
    {
      
        public DbSet<EmployeesEntity> employeesList { get; set; }
        public DbSet<PatientsEntity> patientsList { get; set; }
        public DbSet<QueuesEntity> queuesList { get; set; }
        public DbSet<RoomsEntity> roomsList { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        
    }
}
