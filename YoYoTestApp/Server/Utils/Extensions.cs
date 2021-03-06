﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoYoTestApp.Server
{
    public static class Extensions
    {

        public static bool StringToDoubleThenInt(this string stringId, out int intId)
        {
            double outDouble;
            if (!string.IsNullOrEmpty(stringId) && double.TryParse(stringId, out outDouble))
            {
                intId = (int)outDouble;
                return true;
            }
            intId = 0;
            return false;
        }

        public static int GetIntValueFromJObject(this string json, string key) 
        {
            var jobject = JObject.Parse(json);
            var value = jobject.GetValue(key);
            return value.ToObject<int>();
        }
    }
}
