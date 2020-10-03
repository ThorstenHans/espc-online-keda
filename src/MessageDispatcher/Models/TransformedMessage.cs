using System;
using System.Text.RegularExpressions;

namespace MessageDispatcher.Models
{
    public class TransformedMessage
    {
        public string Message { get; set; }

        public int ExtractNumberOfKittens()
        {
            var chars = Message.ToCharArray();
            Array.Reverse(chars);
            var originalMessage = string.Concat(chars);
            string[] numbers = Regex.Split(originalMessage, @"\D+");
            if (numbers.Length == 0)
            {
                return 0;
            }
            return int.Parse(numbers[1]);
        }
    }
}
