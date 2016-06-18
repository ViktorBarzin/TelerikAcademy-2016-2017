using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoupScript
{
    using System.IO.Ports;
    using System.Text.RegularExpressions;

    class Program
    {
        /*
         Specifications :
          1. Intend code
          2. Remove whitespace
          3. If there is code and comment on the same line, move comment on the previous line
          4. Single whitespace between ")" and "{"
         */

        private static HashSet<string> Operators = new HashSet<string>()
                                                           {
                                                               "+", "-", "=", "<", ">", "!"
                                                           };

        static void Main(string[] args)
        {
            // Read input
            int numberOfLines = int.Parse(Console.ReadLine());
            StringBuilder inputCode = new StringBuilder();
            for (int i = 0; i < numberOfLines; i++)
            {
                inputCode.Append(Console.ReadLine()).AppendLine();
            }

            Console.WriteLine(FormatCode(inputCode.ToString()));

        }

        private static string FormatCode(string inputCode)
        {
            string formattedCode = RemoveWhiteSpaces(inputCode);
            formattedCode = AddWhitespaceBetweenBrackets(formattedCode);
            formattedCode = FormatComments(formattedCode);
            formattedCode = AddIntendation(formattedCode);


            // Format comments 3rd !
            // Add intendation last !

            //RemoveWhiteSpaces(AddIntendation(FormatComments(AddWhitespaceBetweenBrackets(inputCode))));
            //AddWhitespaceBetweenBrackets(FormatComments(AddIntendation(RemoveWhiteSpaces(inputCode))));
            // Add white scape between brackets
            // Add intendation
            // Put comments on previous line
            // Remove white spaces

            return formattedCode.ToString();
        }

        private static string AddWhitespaceBetweenBrackets(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == ')' && input[i + 1] == '{')
                {
                    result.Append(input[i]).Append(" ").Append(input[i + 1]);
                    i++;
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }

        private static string FormatComments(string input)
        {
            StringBuilder result = new StringBuilder();
            string[] lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                int indexOfComment = lines[i].IndexOf("//");
                if (indexOfComment > 0)
                {
                    if (lines[i].Substring(lines[i].Length - indexOfComment).Contains("{")
                    || lines[i].Substring(lines[i].Length - indexOfComment).Contains(";"))
                    {

                        result.Append(lines[i].Substring(indexOfComment)).AppendLine();
                        result.Append(lines[i].Substring(0, indexOfComment)).AppendLine();
                    }
                }
                else
                {
                    result.Append(lines[i]).AppendLine();
                }
            }


            return result.ToString();
        }

        private static string RemoveWhiteSpaces(string input)
        {
            StringBuilder result = new StringBuilder();

            string[] lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Regex.Replace(lines[i], @"\s+", " ");
                var matchForString = Regex.Match(lines[i], "([a-zA-Z=])+(\"(.*?)\")");
                var matchForNumbers = Regex.Match(lines[i], "[A-Za-z]+[*\\/+-=]+[0-9]");

                // Loop through current line of code

                string[] words = lines[i].Split(new[] { ' ' });

                if (matchForNumbers.Success)
                {
                    // Match number variable declaration
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (words[j].Contains("="))
                        {
                            for (int k = 0; k < words[j].Length - 1; k++)
                            {
                                if (words[j][k + 1] != '=')
                                {
                                    result.Append(words[j][k]);
                                }
                                else
                                {
                                    string toAppend = words[j][k] + " = ";
                                    result.Append(toAppend + words[j].Substring(words[j].IndexOf(toAppend) + 1));
                                    k++;
                                }
                            }
                        }
                        else
                        {
                            result.Append(words[j] + " ");
                        }
                    }
                    result.AppendLine();
                }
                else if (matchForString.Success)
                {
                    // Match string variable declaration
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (words[j].Contains("="))
                        {
                            for (int k = 0; k < words[j].Length - 1; k++)
                            {
                                if (words[j][k + 1] != '=')
                                {
                                    result.Append(words[j][k]);
                                }
                                else
                                {
                                    result.Append(words[j][k] + " = \"" + words[j][k + 2] + "\"");
                                    k++;
                                }
                            }
                        }
                        else
                        {
                            result.Append(words[j] + " ");
                        }
                    }
                }
                else
                {
                    result.Append(lines[i]).AppendLine();
                }
            }

            return result.ToString();
        }

        private static string AddIntendation(string Text)
        {
            bool hasBeenDifferent = false;
            string[] text = Regex.Split(Text, "\n");

            int lvl = 0;
            string newString = "";
            foreach (string line in text)
            {
                line.TrimStart(' ');

                if (line.Contains("}") && hasBeenDifferent && lvl - 1 == 0)
                {
                    lvl--;
                }
                newString += indentation(lvl) + line.TrimStart(' ') + "\n";

                if (line.Contains("{"))
                {
                    hasBeenDifferent = true;
                    lvl++;
                }
                if (line.Contains("}"))
                {
                    hasBeenDifferent = true;
                    lvl--;
                }
            }
            return newString.TrimEnd('\n');
        }

        private static string indentation(int IndentLevel)
        {
            string space = "";
            if (IndentLevel > 0)
                for (int lvl = 0; lvl < IndentLevel; lvl++)
                {
                    space += " ".PadLeft(4);
                }

            return space;
        }
    }
}
