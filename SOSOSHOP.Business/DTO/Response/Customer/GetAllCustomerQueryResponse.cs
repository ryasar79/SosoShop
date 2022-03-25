using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSOSHOP.Business.DTO.Response
{
    public class GetAllCustomerQueryResponse
    {
        public int Id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
    }
}
