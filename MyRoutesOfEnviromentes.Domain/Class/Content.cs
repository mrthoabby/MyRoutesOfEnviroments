using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutesOfEnviromentes.Domain.Class
{
    /// <summary>
    /// The content of Route Element
    /// </summary>
    public class Content
    {
        Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
