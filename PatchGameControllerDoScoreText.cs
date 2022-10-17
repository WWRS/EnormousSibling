using HarmonyLib;

namespace EnormousSibling
{
    [HarmonyPatch(typeof(GameController), "doScoreText")]
    internal class PatchGameControllerDoScoreText
    {
        static void Postfix(GameController __instance, ref int whichtext)
        {
            __instance.popuptext.text = Plugin.PopupTexts[whichtext];
            __instance.popuptextshadow.text = Plugin.PopupTexts[whichtext];
        }
    }
}
