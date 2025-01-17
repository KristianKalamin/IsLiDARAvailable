using System.Runtime.InteropServices;

public static class LiDARChecker
{
#if UNITY_IOS
    [DllImport("__Internal")]
    private static extern bool isLiDARSupported();
#endif

    public static bool IsLiDARSupported()
    {
#if UNITY_IOS
        return isLiDARSupported();
#else
        return false;
#endif
    }
}
