using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello Turma .NET 03!";
        }
        [HttpGet("/meunome")]
        public string MeuNome()
        {
            return "Udson";
        }
        [HttpGet("/bsms")]
        public string BSMS()
        {
            return "Proatividade\nComunicação\nPersistência\nOrientação ao Detalhe\nMentalidade de Crescimento\nResponsabilidade Pessoal\nOrientação ao Futuro";
        }
        [HttpGet("/objetivos")]
        public string Objetivos()
        {
            return "Criar Blog Pessoal\nAprender Asp Net\nEstudar Banco de Dados";
        }
    }
}
