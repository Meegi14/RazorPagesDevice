using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesDevice.Models
{
    public class Device
    {

        public int ID { get; set; }
        public string Name { get; set; }
       
        
        public string DevicesTypes { get; set; }
        public string DeviceTypeProperties { get; set; }
        public int DevicesTypeValues { get; set; }
    }   
    

}
