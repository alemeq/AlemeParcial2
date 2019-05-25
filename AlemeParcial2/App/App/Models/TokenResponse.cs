using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    class TokenResponse
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public object Result { get; set; }
    }
}
