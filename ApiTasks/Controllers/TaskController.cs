using System;
using System.Collections.Generic;
using System.Linq;

using ApiTasks.Context;
using ApiTasks.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly AppDbContext context;

        public TaskController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<TaskController>
        [HttpGet]
        public IEnumerable<Tasks> Get()
        {
            var task = context.Tasks.Where(p => p.taskStatus == 1).ToList();
            
            return task;
           
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public Tasks Get(int id)
        {
            var task = context.Tasks.FirstOrDefault(p=>p.taskNumber == id);
           
            return task;
        }

     

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Tasks tasks)
        {
            if (tasks.taskNumber == id)
            {
               // context.Tasks.
                context.Entry(tasks).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

   
    }
}
