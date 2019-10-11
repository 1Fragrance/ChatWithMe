using System;
using System.Collections.Generic;
using System.Text;

namespace ChatWithMe.Common.Infrastructure
{
    public class ErrorInfo
    {
        public ErrorInfo(string key, string description)
        {
            Key = key;
            Description = description;
        }

        public ErrorInfo(string description) : this(nameof(description), description)
        {

        }

        public string Key { get; set; }

        public string Description { get; set; }
    }
}
