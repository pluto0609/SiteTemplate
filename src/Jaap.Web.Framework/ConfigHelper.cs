using System;
using System.Configuration;
using Jaap.Framework;

namespace Jaap.Web.Framework
{
    public sealed class ConfigHelper
    {
        public static string Get(string key)
        {
            try
            {
                var cacheTag = "appconfig_" + key;
                return CacheHelper.Get(cacheTag, () =>
                {
                    var result = ConfigurationManager.AppSettings[key];
                    return result;
                });
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
