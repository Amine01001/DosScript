using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Class2
    {
		public static void work()
		{
			for (int i = 0; i < Vars.threads; i++)
			{
				Vars.threadss.Add(new Thread(new ThreadStart(start)));
			}
			foreach (Thread thread in Vars.threadss)
			{
				thread.Start();
			}
			for (int j = 0; j < Vars.threadss.Count; j++)
			{
				Vars.threadss[j].Join();
			}
			Thread.Sleep(-1);
		}

		private static void start()
		{
			Class3.dos(Vars.target);
		}

	}
}
