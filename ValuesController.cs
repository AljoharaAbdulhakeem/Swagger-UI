using JWT_Token.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace JWT_Token.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route ("All", Name = "GetAllStudents")]
        public IActionResult GetStudents() {

            // Ok - 200 - Success
            return Ok(CollageRepostry.Student);
           
        }

        [HttpGet]
        [Route("{Id:int}", Name = "GetStudentsId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetStudentsId(int Id)
        {
            if (Id <= 0)
            {
                // BadRequest - 400 - BadRequest - clint error
                return BadRequest();
            }

            var student = CollageRepostry.Student.Where(n => n.Id == Id).FirstOrDefault();
            if (student == null)
            {
                // NotFound - 404- NotFound - clin error
                return NotFound($"The student with Id {Id} Not found");
            }

            return Ok(student);

        }

        [HttpGet ("{Name:alpha}", Name = "GetStudentsName")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetStudentsName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                // BadRequest-400-BadRequest - clint error
                return BadRequest();
            }
            var studentName = CollageRepostry.Student.Where(n => n.Name == Name).FirstOrDefault();

            if (studentName == null)
            {
                // NotFound - 404 - NotFound - Clint Error
                return NotFound($"The student with name {Name} NotFound");
            }
            // Ok - 200 - Success
            return Ok(studentName);
        }

        
        [HttpDelete ("{Id}" , Name = "DeleteStudents")]
        public IActionResult DeleteStudents(int Id)
        {

            if (Id <= 0)
            {
                // BadRequest - 400 - BadRequest - clint error
                return BadRequest();
            }

            var student = CollageRepostry.Student.Where(n => n.Id == Id).FirstOrDefault();
            if (student == null)
            {
                // NotFound - 404- NotFound - clin error
                return NotFound($"The student with Id {Id} Not found");
            }

            CollageRepostry.Student.Remove(student);

            // Ok - 200 - Success
            return Ok(true);

        }
    }
}
