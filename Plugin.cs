using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace EnormousSibling
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static string[] PopupTexts;

        private void Awake()
        {
            Logger.LogInfo($"EnormousSibling v{PluginInfo.PLUGIN_VERSION} is assisting you.");
            PopupTexts = LoadPopupTexts();
            Logger.LogInfo($"Popup texts: {PopupTexts[4]}, {PopupTexts[3]}, {PopupTexts[2]}, {PopupTexts[1]}, {PopupTexts[0]}");

            Harmony harmony = new(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
        }

        /** Loads the popup texts in order [f, d, c, b, a] */
        private string[] LoadPopupTexts()
        {
            ConfigEntry<string> a = Config.Bind("Popup Texts", "A", "PERFECTO", "PERFECTO");
            ConfigEntry<string> b = Config.Bind("Popup Texts", "B", "NICE", "NICE");
            ConfigEntry<string> c = Config.Bind("Popup Texts", "C", "OK", "OK");
            ConfigEntry<string> d = Config.Bind("Popup Texts", "D", "MEH", "MEH");
            ConfigEntry<string> f = Config.Bind("Popup Texts", "F", "NASTY", "NASTY");
            return new[] { f.Value, d.Value, c.Value, b.Value, a.Value };
        }
    }
}
