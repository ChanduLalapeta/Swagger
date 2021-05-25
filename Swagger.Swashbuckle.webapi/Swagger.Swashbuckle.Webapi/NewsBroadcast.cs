using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger.Swashbuckle.Webapi
{
    public class NewsBroadcast
    {
        public DateTime Date { get; set; }

        public string HeadLine { get; set; }        

        public string Summary { get; set; }

        public int id { get; set; }
    }
}
