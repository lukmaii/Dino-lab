using System.Collections.Generic;

namespace dinolab
{
    public class AuthResult
    {
        public string Token {get;set;}
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        public string email {get;set;}
    }
}