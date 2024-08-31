using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Department
    {
       public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly CreationDate { get; set; }


        //Navigation Property [Many] -->[Related Data]
        public virtual ICollection<Employee> Employees { get; set; }= new HashSet<Employee>();

       // public Project Project { get; set; } = null!;
    }


    //class Project
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }= null!;
    //}
}
