using Microsoft.AspNetCore.Mvc;

namespace WebApiWithVueSample.Controllers
{
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("/api/Test/Get")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
