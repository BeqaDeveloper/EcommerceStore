namespace EcommerceStore.Domain.Entities
{
    public class AuthResult
    {
        public ApplicationUser ApplicationUser { get; set; }
        public int StatusCode { get; set; }
        public List<string> Message { get; set; }
    }
}
