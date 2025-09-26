using Microsoft.AspNetCore.Mvc;
using NeinAsAService.Models;

namespace NeinAsAService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeinController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly Random _random = new();

        public NeinController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public string Get()
        {
            var answers = _db.Answers.ToList();
            if (answers.Count == 0) return "No answers available!";
            return answers[_random.Next(answers.Count)].Text;
        }

        [HttpPost]
        public ActionResult<Answer> Add(string text)
        {
            var answer = new Answer { Text = text };
            _db.Answers.Add(answer);
            _db.SaveChanges();
            return CreatedAtAction(nameof(GetAll), new { id = answer.Id }, answer);
        }

        [HttpGet("all")]
        public List<Answer> GetAll()
        {
            return _db.Answers.ToList();
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var answer = _db.Answers.Find(id);
            if (answer == null)
                return NotFound("Answer not found!");

            _db.Answers.Remove(answer);
            _db.SaveChanges();

            return Ok("Answer deleted!");
        }
    }
}