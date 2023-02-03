using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonParser.Model
{
    [PrimaryKey(nameof(id))]
    public class clsDagitimModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
