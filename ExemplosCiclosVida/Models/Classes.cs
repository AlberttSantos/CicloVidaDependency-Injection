using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosCiclosVida.Controllers
{
    public class RenderSingleton : IRenderSingleton
    {
        public Guid GetGuidNow { get; private set; } = Guid.NewGuid();
    }

    public class RenderScoped : IRenderScoped
    {
        public Guid GetGuidNow { get; private set; } = Guid.NewGuid();
    }

    public class RenderTransient : IRenderTransient
    {
        public Guid GetGuidNow { get; private set; } = Guid.NewGuid();
    }
}
