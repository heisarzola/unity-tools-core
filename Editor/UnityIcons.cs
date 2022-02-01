using UnityEditor;
using UnityEngine;

namespace SakuraTools.Core.Editor
{
    public static class UnityIcons
    {
        // Icons List: https://github.com/halak/unity-editor-icons

        private static bool IsPro => EditorGUIUtility.isProSkin;

        public static Texture _back, _forward, _settings, _record, _rotate, _transform, _distance, _visibleOn, _visibleOff;

        public static Texture Back => _back ??= IsPro ? EditorGUIUtility.IconContent("d_back").image : EditorGUIUtility.IconContent("back").image;
        public static Texture Forward => _forward ??= IsPro ? EditorGUIUtility.IconContent("d_forward").image : EditorGUIUtility.IconContent("forward").image;
        public static Texture Settings => _settings ??= IsPro ? EditorGUIUtility.IconContent("d__Popup").image : EditorGUIUtility.IconContent("_Popup").image;
        public static Texture Record => _record ??= IsPro ? EditorGUIUtility.IconContent("d_Animation.Record").image : EditorGUIUtility.IconContent("Animation.Record").image;
        public static Texture Rotate => _rotate ??= IsPro ? EditorGUIUtility.IconContent("d_RotateTool On").image : EditorGUIUtility.IconContent("RotateTool On").image;
        public static Texture Transform => _transform ??= IsPro ? EditorGUIUtility.IconContent("d_Transform Icon").image : EditorGUIUtility.IconContent("Transform Icon").image;
        public static Texture Distance => _distance ??= IsPro ? EditorGUIUtility.IconContent("d_DistanceJoint2D Icon").image : EditorGUIUtility.IconContent("DistanceJoint2D Icon").image;
        public static Texture VisibleOn => _visibleOn ??= IsPro ? EditorGUIUtility.IconContent("d_animationvisibilitytoggleon").image : EditorGUIUtility.IconContent("animationvisibilitytoggleon").image;
        public static Texture VisibleOff => _visibleOff ??= IsPro ? EditorGUIUtility.IconContent("d_animationvisibilitytoggleoff").image : EditorGUIUtility.IconContent("animationvisibilitytoggleoff").image;
    }
}