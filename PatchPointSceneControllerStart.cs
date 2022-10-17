using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace EnormousSibling
{
    [HarmonyPatch(typeof(PointSceneController), "Start")]
    internal class PointSceneControllerStartPatch
    {
        private static string[] targetTexts = { "NASTIES", "MEHS", "OKAYS", "NICES", "PERFECTOS" };

        static void Postfix()
        {
            // Set up lists for the texts to fetch
            List<Text>[] targets = new List<Text>[targetTexts.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                targets[i] = new List<Text>();
            }
            
            // Populate lists by searching over all of the Texts. Sadly there's no
            // better way to do this, since we don't have any references to the targets.
            Text[] texts = Object.FindObjectsOfType<Text>();
            foreach (Text text in texts)
            {
                int index = Array.IndexOf(targetTexts, text.text);
                if (index >= 0) targets[index].Add(text);
            }

            // Set all the texts to the corresponding strings
            for (int i = 0; i < targets.Length; i++)
            {
                string newText = Plugin.PopupTexts[i] + "s";
                foreach (Text text in targets[i])
                {
                    text.text = newText;
                }
            }
        }
    }
}
