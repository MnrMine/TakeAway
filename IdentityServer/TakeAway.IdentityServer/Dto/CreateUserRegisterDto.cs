namespace TakeAway.IdentityServer.Dto
{
    public class CreateUserRegisterDto
    {
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
