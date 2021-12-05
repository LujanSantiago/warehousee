using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class jsonporcentajes
    {
        public class respuesta
        {
            public List<based> registro { get; set; }
        }
        public class based
        {
            public string id { get; set; }
            public string porcentajeventas { get; set; }
            public string porcentajepara100 { get; set; }

        


    }
}
}
