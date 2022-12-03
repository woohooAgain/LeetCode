using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsSubsequenceClass
    {
        public bool IsSubsequence(string s, string t)
        {
			if (s.Length == 0) return true;

			int s_pointer = 0;
			for (int t_pointer = 0; t_pointer < t.Length; t_pointer++)
			{
				if (s[s_pointer] == t[t_pointer])
				{
					s_pointer++;
					if (s_pointer == s.Length) return true;
				}
			}
			return false;
		}
    }
}
