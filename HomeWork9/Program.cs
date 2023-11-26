using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Task1
			//string[] words = { "This", "is", "an", "example", "of", "text", "justification." };
			//int maxWidht = 16;
			//string formatText = FormatText(words, maxWidht);
			//Console.WriteLine(formatText);
			#endregion
			#region Task2
			//string s = "the sky is blue";
			//string reversedSentence = TersSozler(s);
			//Console.WriteLine(reversedSentence);
			#endregion
			#region Task3

			string s = "Hello World";
			int lengthOfLastWord=LengthOfLastWord(s);	
			Console.WriteLine(lengthOfLastWord);	
			#endregion
		}

		    #region Task1
		//static string FormatText(string[] words, int maxWidht)
		//{
		//	int currentWidht = 0;
		//	StringBuilder result = new StringBuilder();
		//	foreach (string word in words)
		//	{
		//		if (currentWidht + word.Length <= maxWidht)
		//		{
		//			result.Append(word + " ");
		//			currentWidht += word.Length + 1;
		//		}
		//		else
		//		{
		//			result.Append("\n");
		//			currentWidht = word.Length + 1;
		//			result.Append(word + " ");
		//		}


		//	}
		//	return result.ToString().TrimEnd();


		//		}


			//	}
			#endregion
			#region Task2
			//static string TersSozler(string s)
			//{

			//	string[] words = s.Split(' ');
			//	Array.Reverse(words);
			//	string reversedSentence = string.Join(" ", words);

			//	return reversedSentence;
			//}

			#endregion
			#region Task3

		static int LengthOfLastWord (string s)
		{
			s = s.Trim();
			int length = 0;
			for (int i = s.Length - 1; i >= 0; i--)
			{
				if (s[i] != ' ')

				{

					length++;


				}
				else
				{

					break;
				}

			}
			return length;	
		
		
		}
			


		}
	#endregion
}
