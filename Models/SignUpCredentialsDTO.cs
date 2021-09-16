using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace proj_semestre_backend.Models {
    public class SignUpCredentialsDTO {
        [Required(ErrorMessage = "Informe o seu nome de usuário")]
        public string username { get; set; }

        [Required(ErrorMessage = "Informe a sua senha")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Informe uma senha válida")]        
        public string password { get; set; }

        public string role { get; set; }

        [JsonConstructor]
        public SignUpCredentialsDTO(
            string username,
            string password
        ) {
            this.role = "user";
            this.username = username;
            this.password = password;
        }

    }
}