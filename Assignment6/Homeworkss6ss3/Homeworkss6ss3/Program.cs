using System;

namespace Homeworkss6ss3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int column = 10; int row = 10;
			for (int i = 0; i < column; i++) {
				Console.Write ("* ");
			}
			for (int i = 0; i < column / 2; i++) {
				Console.Write ("X * ");
			}
			Console.WriteLine ();
			for (int i = 0; i < row / 2; i++) {
				for (int j = 0; j < column / 2; j++) {
					Console.Write (" X * ");
				}
				Console.WriteLine ();
				for (int j = 0; j < column / 2; j++) {
					Console.Write (" * X ");
				} Console.WriteLine ();
			}
		}
	}
}
