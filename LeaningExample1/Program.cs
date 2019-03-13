using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaningExample1
{
	class Program
	{
		static void Main(string[] args)
		{
			String[] words = {"Substring","hypertext ","impossible","disagree","defrost","unfortunately"};


			Console.WriteLine("...............................................................");
			Console.WriteLine("\t\tENGLISH WORD PREFIX GAME");
			Console.WriteLine("...............................................................");

			//foreach(String element in words)

		
		for (int index = 0; index < words.Length; index++)
				{
				Console.WriteLine("What is the correct prefix of the {0}: ", words[0]);
				String firstName = Console.ReadLine();

				Console.WriteLine("What is the correct prefix of the {0} : ", words[1]);
				String secondName = Console.ReadLine(            );

				if (firstName == "sub" && secondName == "hyper")
					{
						Console.WriteLine("correct");
					}
					else
						Console.WriteLine("incorrect");
					break;

				}

		Console.WriteLine("CHECK YOUR ANSWERES");
		Console.WriteLine("==================================================================");
		Console.WriteLine("WORD\t\t\tPREFIX\t\tDESCRIPTION");
		Console.WriteLine("===================================================================");
		Console.WriteLine(words[0] + "\t\tsub\n");
		Console.WriteLine(words[1] + "\t\thyper\n");

			
		Console.Write("Next? press y for next play");
		String nextGame = Console.ReadLine();

			while (nextGame == "y")
			{

				for (int index = 0; index < words.Length; index++)
				{
					Console.WriteLine("What is the correct prefix of the {0}: ", words[2]);
					String firstName = Console.ReadLine();

					Console.WriteLine("What is the correct prefix of the {0} : ", words[3]);
					String secondName = Console.ReadLine();

					if (firstName == "im" && secondName == "dis")
					{
						Console.WriteLine("correct");
					}
					else
						Console.WriteLine("incorrect");
					break;

				}

				Console.WriteLine("CHECK YOUR ANSWERES");
				Console.WriteLine("==================================================================");
				Console.WriteLine("WORD\t\t\tPREFIX\t\tDESCRIPTION");
				Console.WriteLine("===================================================================");
				Console.WriteLine(words[0] + "\t\tsub\n");
				Console.WriteLine(words[1] + "\t\thyper\n");

				Console.Write("Next? press y for next play");
				String nextGame3 = Console.ReadLine();
			
				if (nextGame3 == "y")
				{ 

					for (int index = 0; index < words.Length; index++)
					{
						Console.WriteLine("What is the correct prefix of the {0}: ", words[4]);
						String firstName = Console.ReadLine();

						Console.WriteLine("What is the correct prefix of the {0} : ", words[5]);
						String secondName = Console.ReadLine();

						if (firstName == "im" && secondName == "dis")
						{
							Console.WriteLine("correct");
						}
						else
							Console.WriteLine("incorrect");
						break;

					}

					Console.WriteLine("CHECK YOUR ANSWERES");
					Console.WriteLine("==================================================================");
					Console.WriteLine("WORD\t\t\tPREFIX\t\tDESCRIPTION");
					Console.WriteLine("===================================================================");
					Console.WriteLine(words[0] + "\t\tsub\n");
					Console.WriteLine(words[1] + "\t\thyper\n");

					Console.Write("Game ended");
					Console.ReadLine();
				}
				break;
			} 


		}
	}
}

