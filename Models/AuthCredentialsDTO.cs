using System.ComponentModel.DataAnnotations;

namespace proj_semestre_backend.Models {
    public class AuthCredentialsDTO {

        [Required(ErrorMessage = "Informe o seu nome de usuário")]
        public string username { get; set; }


        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Informe uma senha válida")]        
        public string password { get; set; }

    }
}