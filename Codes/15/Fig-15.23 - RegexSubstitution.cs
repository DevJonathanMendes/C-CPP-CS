// Fig. 15.23: RegexSubstitution.cs
// Usando o método Replace de Regex

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

public class RegexSubstitution1 : Form
{
	[STAThread]
	static void Main(string[] args)
	{
		string testString1 = "This sentence ends in 5 stars *****";

		string testString2 = "1, 2, 3, 4, 5, 6, 7, 8";
		Regex testRegex1 = new Regex("stars");
		Regex testRegex2 = new Regex(@"\d");
		string[] results;
		string output = "Original String 1\t\t\t" + testString1;

		testString1 = Regex.Replace(testString1, @"\*", "^");

		output += "\n^ substituted  for *\t\t\t" + testString1;

		testString1 = testRegex1.Replace(testString1, "carets");

		output += "\n\"carets\" substituted for \"stars\"\t\t" + testString1;

		output += "\nEvery word replaced by \"word\"\t" +
			Regex.Replace(testString1, @"\w+", "word");

		output += "\n\nOriginal String 2\t\t\t" + testString2;

		output += "\nFirst 3 digits replaced by \"digit\"\t\t" +
		testRegex2.Replace(testString2, "digit", 3);

		output += "\nString split at commas\t\t[";

		results = Regex.Split(testString2, @", \s*");

		foreach (string resultString in results)
		{
			output += "\"" + resultString + "\", ";
		}

		output = output.Substring(0, output.Length - 2) + "]";


		MessageBox.Show(output, "Substitution using regular expressions",
			MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
