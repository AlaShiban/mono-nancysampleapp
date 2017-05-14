using System;
using Nancy.Hosting.Self;

namespace MonoMyFirstNancy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			using (var host = new NancyHost(new Uri("http://127.0.0.1:4321")))
			{
				host.Start();
				Console.WriteLine("Running on http://127.0.0.1:4321");
				Console.ReadLine();
			}
        }
    }

	public class SampleModule : Nancy.NancyModule
	{
		public SampleModule()
		{
			Get["/"] = _ => "Hello World!";
		}
	}
}
