using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagement
{
    public class OperationLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MyProperty { get; set; }
        public string  TriggerUser { get; set; }
        public string  Status { get; set; }
        public string ExcecutionNumber { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
