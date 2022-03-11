using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")] //www.google.com/api/First/getName
    [ApiController]
    public class FirstController : ControllerBase
    {
        [HttpGet("getName")]
        public string GetName()
        {
            return "Welcome to API Course.";
        }

        [HttpGet("getDepartment")]
        public string GetDepartment()
        {
            return "Department = IT";
        }

        [HttpGet("getById/{id}")]
        public string GetById(int id)
        {
            return "Your Id is: " + id;
        }
    }
}
