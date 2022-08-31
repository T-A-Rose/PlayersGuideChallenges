using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePasswordValidator
{
    internal class MessageOutput
    {
        public void DisplayMessage(string userMessage)
        {
            Console.WriteLine(userMessage);
        }

        public string ReadMessage()
        {
            return Console.ReadLine();
        }

    }
}
