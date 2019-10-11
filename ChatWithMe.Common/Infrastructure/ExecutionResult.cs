using System;
using System.Collections.Generic;
using System.Text;

namespace ChatWithMe.Common.Infrastructure
{
    public class ExecutionResult
    {
        public bool IsSuccess { get; set; }

        public IList<ErrorInfo> Errors { get; set; }

        public ResultBase Data { get; set; }

        public ExecutionResult(ResultBase data)
        {
            Data = data;
            IsSuccess = true;
        }

        public ExecutionResult(IList<ErrorInfo> errors)
        {
            Errors = errors;
            IsSuccess = false;
        }

        public ExecutionResult() : this((ResultBase) null)
        {

        }
    }
}
