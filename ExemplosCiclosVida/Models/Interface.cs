using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosCiclosVida.Controllers
{
    public interface IRender
    {
        Guid GetGuidNow { get; }
    }
    public interface IRenderSingleton : IRender
    {
    }
    public interface IRenderScoped : IRender
    {
    }
    public interface IRenderTransient : IRender
    {
    }
}
