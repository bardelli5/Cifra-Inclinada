using System;
using System.Globalization;

namespace CodigoTeste {
    class Program {
        static void Main(string[] args) {

            int numberOfRows = int.Parse(Console.ReadLine());
            string encodedString = Console.ReadLine();

            int length = encodedString.Length / numberOfRows;

            string[] rows = new string[numberOfRows];

            for (int i = 0; i < numberOfRows; i++) {
                string substring = encodedString.Substring(length * i, length);
                rows[i] = substring;
            }

            List<char> decodedResult = new List<char>();

            for (int j = 0; j < length; j++) {
                for (int i = 0; i < numberOfRows; i++) {
                    if (rows[i].Length > j + i) {
                        decodedResult.Add(getResult(rows[i][j + i]));
                    }
                }
            }
            Console.WriteLine(new string(decodedResult.ToArray()));

        }
        public static char getResult(char character) {
            if (character == '_') {
                return ' ';
            }
            else {
                return character;
            }
        }
    }
}


