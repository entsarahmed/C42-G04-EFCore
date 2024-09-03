using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
     class Department
    {
        public int DeptId { get; set; }

        public int Code { get; set; }

        public string? Name { get; set; }

        public DateOnly CreationDate { get; set; }

        

    }

}
 