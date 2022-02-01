using UnityEngine;

namespace SakuraTools
{
    public static class ExtensionGameObject
    {
        public static void SetHideFlags(this GameObject go, HideFlags newFlags, bool includeChildren = true)
        {
            go.hideFlags = newFlags;
            if (!includeChildren) { return; }
            foreach (Transform t in go.GetComponentsInChildren<Transform>())
            {
                t.gameObject.hideFlags = newFlags;
            }
        }

        public static void MarkAsUneditable(this GameObject go)
        {
            go.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
        }
    }
}