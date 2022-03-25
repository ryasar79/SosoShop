namespace SOSOSHOP.Core.Validators
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    public class ValidatorException : Exception
    {
        private bool Success { get; set; }

        private int StatusCode { get; set; }

        public List<string> Errors { get; set; }


        public ValidatorException(List<string> errors)
        {
            Success = false;
            StatusCode = StatusCodes.Status400BadRequest;
            Errors = errors;
        }
    }
}
