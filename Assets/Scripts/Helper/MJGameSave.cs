using UnityEngine;
using System.Collections.Generic;

namespace MJGame.Extensions
{
    
    public static class MJGameSave
    {
        #region Bool 

        public static bool GetBool(string key)
        {
            return (PlayerPrefs.GetInt(key, 0) == 1);
        }

        public static bool GetBool(string key, bool defaultValue)
        {
            return (PlayerPrefs.GetInt(key, (defaultValue ? 1 : 0)) == 1);
        }

        public static void SetBool(string key, bool value)
        {
            PlayerPrefs.SetInt(key, (value ? 1 : 0));
        }

        #endregion

        #region List <T>

        public class ListWrapper<T>
        {
            public List<T> list = new List<T>();
        }

        public static List<T> GetList<T>(string key)
        {
            return Get<ListWrapper<T>>(key, new ListWrapper<T>()).list;
        }

        public static List<T> GetList<T>(string key, List<T> defaultValue)
        {
            return Get<ListWrapper<T>>(key, new ListWrapper<T> { list = defaultValue }).list;
        }

        public static void SetList<T>(string key, List<T> value)
        {
            Set(key, new ListWrapper<T> { list = value });
        }

        #endregion

        //Generic template

        static T Get<T>(string key, T defaultValue)
        {
            return JsonUtility.FromJson<T>(PlayerPrefs.GetString(key, JsonUtility.ToJson(defaultValue)));
        }

        static void Set<T>(string key, T value)
        {
            PlayerPrefs.SetString(key, JsonUtility.ToJson(value));
        }

    }
}