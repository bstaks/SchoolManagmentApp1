using DLLApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLApp.ViewModels
{
   public class StudentInfoViewModels
    {
        public Student Student { get; set; }
        public AspNetUser Users { get; set; }
        public AddressInfo AddressInfo { get; set; }
    }
}
