using System;

namespace CadastroApp.Data
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Altura { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
