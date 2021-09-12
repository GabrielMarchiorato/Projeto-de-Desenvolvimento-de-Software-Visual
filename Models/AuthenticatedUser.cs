namespace proj_semestre_backend.Models {
    public class AuthenticatedUser {
        public User user { get; set; }
        public string token { get; set; }
    }
}