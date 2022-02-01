using UnityEngine;

namespace SakuraTools.Core
{
    public static class PlayerPrefsHelper
    {
        public static Color GetColor(string key, Color defaultValue)
        {
            return new Color
            (
                PlayerPrefs.GetFloat($"{key}_C_R", defaultValue.r),
                PlayerPrefs.GetFloat($"{key}_C_G", defaultValue.g),
                PlayerPrefs.GetFloat($"{key}_C_B", defaultValue.b),
                PlayerPrefs.GetFloat($"{key}_C_A", defaultValue.a)
            );
        }

        public static void SetColor(string key, Color value)
        {
            PlayerPrefs.SetFloat($"{key}_C_R", value.r);
            PlayerPrefs.SetFloat($"{key}_C_G", value.g);
            PlayerPrefs.SetFloat($"{key}_C_B", value.b);
            PlayerPrefs.SetFloat($"{key}_C_A", value.a);
            PlayerPrefs.Save();
        }

        public static bool GetBool(string key, bool defaultValue)
        {
            int i = PlayerPrefs.GetInt($"{key}_B", defaultValue ? 1 : 0);
            return i == 1;
        }

        public static void SetBool(string key, bool value)
        {
            PlayerPrefs.SetInt($"{key}_B", value ? 1 : 0);
        }

        public static Vector3 GetVector3(string key, Vector3 defaultValue)
        {
            float x = PlayerPrefs.GetFloat($"{key}_X", defaultValue.x);
            float y = PlayerPrefs.GetFloat($"{key}_Y", defaultValue.y);
            float z = PlayerPrefs.GetFloat($"{key}_Z", defaultValue.z);

            return new Vector3(x, y, z);
        }

        public static void SetVector3(string key, Vector3 value)
        {
            PlayerPrefs.SetFloat($"{key}_X", value.x);
            PlayerPrefs.SetFloat($"{key}_Y", value.y);
            PlayerPrefs.SetFloat($"{key}_Z", value.z);
        }

        public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
        {
            float x = PlayerPrefs.GetFloat($"{key}_X_Q", defaultValue.x);
            float y = PlayerPrefs.GetFloat($"{key}_Y_Q", defaultValue.y);
            float z = PlayerPrefs.GetFloat($"{key}_Z_Q", defaultValue.z);
            float w = PlayerPrefs.GetFloat($"{key}_W_Q", defaultValue.w);

            return new Quaternion(x, y, z, w);
        }

        public static void SetQuaternion(string key, Quaternion value)
        {
            PlayerPrefs.SetFloat($"{key}_X_Q", value.x);
            PlayerPrefs.SetFloat($"{key}_Y_Q", value.y);
            PlayerPrefs.SetFloat($"{key}_Z_Q", value.z);
            PlayerPrefs.SetFloat($"{key}_W_Q", value.w);
        }

        public static Vector2 GetVector2(string key, Vector2 defaultValue)
        {
            float x = PlayerPrefs.GetFloat($"{key}_X2", defaultValue.x);
            float y = PlayerPrefs.GetFloat($"{key}_Y2", defaultValue.y);

            return new Vector2(x, y);
        }

        public static void SetVector2(string key, Vector2 value)
        {
            float x = value.x;
            float y = value.y;

            PlayerPrefs.SetFloat($"{key}_X2", x);
            PlayerPrefs.SetFloat($"{key}_Y2", y);
        }
    }
}