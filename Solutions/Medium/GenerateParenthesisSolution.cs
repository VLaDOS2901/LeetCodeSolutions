using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
	public class GenerateParenthesisSolution
	{

		public static IList<string> GenerateParenthesis(int n)
		{
			List<string> strings = new List<string>();
			int maxLength = n * 2;
			void Backtrack(string current, int openCount, int closedCount)
			{
				if (current.Length == maxLength)
				{
					strings.Add(current);
					return; 
				}
				if (openCount < n)
				{
					Backtrack(current + "(", openCount + 1, closedCount);
				}
				if(closedCount < openCount)
				{
					Backtrack(current + ")", openCount, closedCount + 1);
				}
				
			}
			Backtrack("", 0, 0);

			
			
			return strings;

		}
	}
}
