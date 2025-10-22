using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VL.IO.OptiTrack
{
    public static class DllLoadFix
    {
        public static void LoadNatNetLib()
        {
            NativeLibrary.Load("NatNetLib", typeof(DllLoadFix).Assembly, searchPath: default);
        }
    }
}