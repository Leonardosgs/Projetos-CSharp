namespace Listando.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public UsuarioModel()
        {

        }



    }

}
