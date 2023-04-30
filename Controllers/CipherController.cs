using Microsoft.AspNetCore.Mvc;
using CipherAPI.Models;

namespace CipherAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CipherController : ControllerBase
    {
        private readonly Cipher _cipher;

        public CipherController()
        {
            _cipher = new Cipher();
        }

        [HttpPost("encrypt")]
        public IActionResult Encrypt(CipherRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Language) || string.IsNullOrWhiteSpace(request.Text))
            {
                return BadRequest("Invalid request");
            }

            string encryptedText;

            switch (request.Language.ToLower())
            {
                case "english":
                    encryptedText = _cipher.ROT13(request.Text);
                    break;
                case "russian":
                    encryptedText = _cipher.ROT16(request.Text);
                    break;
                default:
                    return BadRequest("Invalid language");
            }

            return Ok(new { encryptedText });//converted to json
        }
    }
}
