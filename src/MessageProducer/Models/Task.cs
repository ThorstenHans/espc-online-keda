using System;
using System.Collections.Generic;

namespace MessageProducer.Models
{
    public class Task
    {
        public Task(string message, int parameter)
        {
            this.Message = message;
            this.Parameters = new List<object> { parameter };
        }

        public string Message {get;set;}
        public List<object> Parameters { get; set; }
    }
}
