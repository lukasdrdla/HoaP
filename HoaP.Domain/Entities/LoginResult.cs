namespace HoaP.Domain.Entities
{
    public class LoginResult
    {
        public bool Succeeded { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsNotAllowed { get; set; }

        public static LoginResult Success => new() { Succeeded = true };
        public static LoginResult Failed => new();
        public static LoginResult LockedOut => new() { IsLockedOut = true };
        public static LoginResult NotAllowed => new() { IsNotAllowed = true };
    }
}
