using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SakuraTools
{
    public static class ExtensionComponent
    {
        public static void EditorDestroyGameObject<T>(this T c, bool targetRoot = false) where T : Component
        {
            GameObject target = targetRoot ? c.transform.root.gameObject : c.gameObject;
#if UNITY_EDITOR
            SceneVisibilityManager.instance.EnablePicking(target, true);
            target.SetHideFlags(HideFlags.None);
            EditorApplication.delayCall += () =>
            {
                Object.DestroyImmediate(target);
            };
            return;
#else
            Object.Destroy(target);
#endif
        }
    }
}