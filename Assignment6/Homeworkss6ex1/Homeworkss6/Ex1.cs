using System;

namespace Homeworkss6
{
	class MainClass
	{ 
		public static void Main (string[] args)
		{
			Console.WriteLine ("What is your height?");
			int height = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("What is your weight?");
			int weight = Convert.ToInt32(Console.ReadLine());
	        double bmi = weight / ( height * height / 10000.0);
			Console.WriteLine(" Your bmi is" + bmi);
			Console.Write("You're ");
			if(bmi < 16){
				Console.WriteLine("severely underweight");
			
			}
			else{
				if(bmi < 18.5){
					Console.WriteLine("underweight");

				}
				else{
					if(bmi < 25){
						Console.WriteLine("Normal");

					}
					else{
						if(bmi < 30){
							Console.WriteLine("overweight");

						}
						else{
							Console.WriteLine("obese");
						}
					}
				}
			}
		}


	}
}
	