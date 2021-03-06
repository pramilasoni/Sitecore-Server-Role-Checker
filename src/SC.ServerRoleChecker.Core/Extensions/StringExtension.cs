﻿using System;

namespace SC.ServerRoleChecker.Core.Extensions
{
    public static class StringExtension
    {
        public static string ToSanitizedConfigFileName(this string configFileName)
        {
            if (string.IsNullOrWhiteSpace(configFileName))
                return string.Empty;

            //the tool does not support oracle config as of now
            if(configFileName.ToLowerInvariant().Contains("oracle"))
                return configFileName;

            var pos = configFileName.IndexOf(".config", StringComparison.Ordinal);
            if (pos > 0)
            {
                return configFileName.Substring(0, pos + 7);
            }
            
            return configFileName;
        }
    }
}
