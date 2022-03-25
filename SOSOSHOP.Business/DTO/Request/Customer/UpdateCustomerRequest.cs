using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSOSHOP.Business.DTO.Request
{
    public class UpdateCustomerRequest
    {
        public int Id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
    }
}
