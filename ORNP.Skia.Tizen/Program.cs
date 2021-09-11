using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ORNP.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ORNP.App(), args);
            host.Run();
        }
    }
}
