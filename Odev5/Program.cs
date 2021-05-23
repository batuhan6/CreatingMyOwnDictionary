using System;
using System.Collections.Generic;

namespace Dictionary_ödev5
{
    class Program
    {
        private static Dictionary<string, object> dict;

        private static void Add(string strKey, object dataType)
        {
            if (!dict.ContainsKey(strKey))
            {
                dict.Add(strKey, dataType);
            }
            else
            {
                dict[strKey] = dataType;
            }
        }

        private static T GetAnyValue<T>(string strKey)
        {
            object obj;
            T retType;

            dict.TryGetValue(strKey, out obj);

            try
            {
                retType = (T)obj;
            }
            catch
            {
                retType = default(T);
            }
            return retType;
        }

        static void Main(string[] args)
        {
            dict = new Dictionary<string, object>();

            Add("pi", 3.14);
            Add("dongu", "Round and round");
            Console.WriteLine(GetAnyValue<double>("pi"));
            Console.WriteLine(GetAnyValue<string>("dongu"));
            Console.ReadLine();
        }
    }


}

