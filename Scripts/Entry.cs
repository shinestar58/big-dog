using System.Reflection;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;
using STS2RitsuLib;
using STS2RitsuLib.Interop;
using STS2RitsuLib.Audio;

namespace BigDog.Scripts;

[ModInitializer(nameof(Init))]

public class Entry
{
    // 你的modid,与json格式一致！
    public const string ModId = "BigDog";
    public static readonly Logger Logger = RitsuLibFramework.CreateLogger(ModId);

    public static void Init()
    {
        // harmony可用，但是最好用ritsu的封装patch，见补丁系统一章
        // var harmony = new Harmony("com.example.testmod");
        // harmony.PatchAll();
        var assembly = Assembly.GetExecutingAssembly();
        RitsuLibFramework.EnsureGodotScriptsRegistered(assembly, Logger);
        // 自动注册内容
        ModTypeDiscoveryHub.RegisterModAssembly(ModId, assembly);

        //初始化音频
        // FmodStudioDeferredBankRegistration.RegisterBank("res://nailong/audios/nailong.bank");
        // FmodStudioDeferredBankRegistration.RegisterStudioGuidMappings("res://nailong/audios/GUIDs.txt");

        //预载音频
        // FmodStudioStreamingFiles.TryPreloadAsSound("res://nailong/audios/nailongLaugh.wav");
    }
}