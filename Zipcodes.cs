using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace i18n_zipcodes_csharp
{
    public static class Zipcodes
    {
        public static bool Validate(string countryCode, string zipCode)
        {
            var countryCodeId = countryCode.Trim().ToLower();
            var zipCodeId = zipCode.Trim();

            if (countryCodeId == "uk")
            {
                countryCodeId = "gb";
            }

            if (countryCodeId == "cs")
            {
                throw new Exception("'CS' is an invalid country code, use 'RS' and/or 'ME' instead.");
            }

            Regex zipCodeRegex = null;
            // Associate the good Regex for the countryCode input
            if (ZipRegexLib.uniqueZip.ContainsKey(countryCodeId))
            {
                // If `countryCode` parameter is detected as a unique key
                zipCodeRegex = ZipRegexLib.uniqueZip[countryCodeId];
            }
            else
            {
                // Else `countryCode` parameter is detected as a common key
                for (var i = 0; ZipRegexLib.commonZip.countryCode.Length > 1; i++)
                {
                    // Looping through each shared regex countries array
                    if (ZipRegexLib.commonZip.countryCode[i].Contains(countryCodeId))
                    {
                        // If a match is found, set the associated regex
                        zipCodeRegex = ZipRegexLib.commonZip.pattern[i];
                        break;
                    }
                }
            }

            if (zipCodeRegex != null)
            {
                return zipCodeRegex.IsMatch(zipCodeId);
            }
            else
            {
                throw new Exception("No Regex corresponds to this country code");
            }
        }
    }
}