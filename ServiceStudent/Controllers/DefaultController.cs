using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ServiceStudent.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        static List<Student> list = new List<Student>() {
            new Student(){ ID = "001", StudentName = "学生1", StudentAge = 16 },
            new Student(){ ID = "002", StudentName = "学生2", StudentAge = 18 },
            new Student(){ ID = "003", StudentName = "学生3", StudentAge = 17 }
        };

        /// <summary>
        /// 健康检查接口
        /// </summary>
        [HttpGet]
        public string Check()
        {
            Console.WriteLine("Check-" + DateTime.Now.ToString());
            return "1";
        }

        [HttpGet]
        public List<Student> GetList()
        {
            Console.WriteLine("GetList-" + DateTime.Now.ToString());
            return list;
        }

        [HttpGet]
        public Student GetModel(string id)
        {
            Console.WriteLine("GetModel-" + DateTime.Now.ToString());
            return list.Find(t => t.ID == id);
        }
    }
}