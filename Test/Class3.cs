using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;

namespace Test
{
	class Class3
	{
		public static bool dos(string target)
		{
			for (; ; )
			{
				using (HttpRequest req = new HttpRequest())
				{
                    try
                    {
						req.Get(target);
						Console.WriteLine(" [+] Request Sent !!");
						return false;
					}
                    catch
                    {
						continue;
                    }
					
				}
			}
		}
	}
}
