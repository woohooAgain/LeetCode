using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsoStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            var length = s.Length;
            var dict = new Dictionary<char, char>();
            var hash = new HashSet<char>();
            for (var i = 0; i < length; i++)
            {                
                if (!dict.TryGetValue(s[i], out var savedValue))
                {
                    if (!hash.Add(t[i]))
                    {
                        return false;
                    }
                    dict[s[i]] = t[i];
                }
                else
                {
                    if (savedValue != t[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
