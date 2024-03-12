using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace i18n_zipcodes_csharp
{
    internal static class ZipRegexLib
    {
        internal static Dictionary<string, Regex> uniqueZip = new Dictionary<string, Regex>()
        {
            { "ad", new Regex(@"^(([a-zA-Z]{2}\d{3})|(\d{4}))$")},
            { "ar", new Regex(@"^((\d{4})|([a-zA-Z]{1}\d{4}[a-zA-Z]{3}))$")},
            { "bm", new Regex(@"^[a-zA-Z]{2}\s\d{2}$")},
            { "bn", new Regex(@"^[a-zA-Z]{2}\d{4}$")},
            { "br", new Regex(@"^(\d{5})(-\d{3})?$")},
            { "ca", new Regex(@"^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$")},
            { "fo", new Regex(@"^([a-zA-Z]{2}-)?(\d{3})?$")},
            { "fr", new Regex(@"^((0[1-9])|([1-8][0-9])|(9[0-8])|(2A)|(2B))[0-9]{3}$")},
            { "gb", new Regex(@"^(([A-Z]{1,2}[0-9][A-Z0-9]?|ASCN|STHL|TDCU|BBND|[BFS]IQQ|PCRN|TKCA) ?[0-9][A-Z]{2}|BFPO ?[0-9]{1,4}|(KY[0-9]|MSR|VG|AI)[ -]?[0-9]{4}|[A-Z]{2} ?[0-9]{2}|GE ?CX|GIR ?0A{2}|SAN ?TA1)$")},
            { "ge", new Regex(@"^((\d{4})|(\d{6}))$")},
            { "ie", new Regex(@"^(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$")},
            { "il", new Regex(@"^((\d{5})|(\d{7}))$")},
            { "jp", new Regex(@"^\d{3}(-\d{4})?$")},
            { "lv", new Regex(@"^([a-zA-Z]{2}-)?(\d{4})$")},
            { "mv", new Regex(@"^\d{4,5}$")},
            { "mt", new Regex(@"^[a-zA-Z]{3}\s\d{2,4}$")},
            { "nl", new Regex(@"^(\d{4})\s?[a-zA-Z]{2}$")},
            { "pl", new Regex(@"^\d{2}(-)?\d{3}$")},
            { "pt", new Regex(@"^\d{4}(-)?\d{3}$")},
            { "sz", new Regex(@"^[a-zA-Z]{1}\d{3}$")},
            { "tw", new Regex(@"^\d{3}(\d{2})?$")},
            { "us", new Regex(@"^\d{5}(-\d{4})?$")},
        };

        internal static (string[][] countryCode, Regex[] pattern) commonZip = (
            new string[][]
            {
                "is|mg".Split('|'),
                "at|au|bd|be|bg|ch|cx|cy|dk|gl|gw|hu|li|lu|md|mk|mz|no|nz|ph|sd|si|tn|ve|xk|za".Split('|'),
                "as|ba|cu|de|dz|ee|es|fi|fm|gf|gp|gt|gu|hr|ic|id|it|ke|kr|kw|lt|ma|me|mh|mm|mp|mq|mx|my|pk|pm|pr|ps|pw|re|sa|sm|th|tr|ua|uy|vi|vn|yu|zm".Split('|'),
                "am|az|bj|by|cn|co|in|kg|kz|mn|ro|rs|ru|sg|tj|tm|uz".Split('|'),
                "cz|gr|se|sk".Split('|')
            },
            new Regex[]
            {
                new Regex(@"^[0-9]{3}$"),
                new Regex(@"^[0-9]{4}$"),
                new Regex(@"^[0-9]{5}$"),
                new Regex(@"^[0-9]{6}$"),
                new Regex(@"^[0-9]{3}\s?[0-9]{2}$"),
            }
            );
    }
}
