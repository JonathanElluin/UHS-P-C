using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class SharedObjects
    {
        private static Dictionary<string,object> SharedObject = new Dictionary<string, object>();

        public static void SetInt(string key, int value)
        {
            if ( !SharedObject.ContainsKey(key)){ 
                SharedObject.Add(key, value);
            }
        }


        public static int GetInt(string key)
        {
            return (int)SharedObject[key];
        }
    }
}
