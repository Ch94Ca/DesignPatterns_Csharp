namespace Adapter.Entities
{
    class Token
    {
        public string AuthToken { get; set; }
        public Token(string authToken)
        {
            AuthToken = authToken;
        }
    }
}
