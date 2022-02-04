using MyRoutesOfEnviromentes.Domain.Class;
using MyRoutesOfEnviromentes.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutesOfEnviromentes.Domain.Entities
{
    /// <summary>
    /// The route. is a document that contain iformation about a configuration or enviroment of work
    /// </summary>
    public class Route
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EnumRouteType RouteType { get; set; }
        public List<Content> Contents { get; set; }
    }
}
