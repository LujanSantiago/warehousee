using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class json
    {
        public class respuesta
        {
            public List<based> registro { get; set; }
        }
        public class based
        {
            public string id { get; set; }
            public string nombre { get; set; }
            public string cantidad { get; set; }
            public string precio { get; set; }
            public string descripcion { get; set; }
            
        }
    }
}
