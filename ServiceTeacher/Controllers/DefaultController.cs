using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceTeacher.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        static List<Teacher> list = new List<Teacher>() {
            new Teacher(){ ID = "001", TeacherName = "老师1", TeacherAge = 31 },
            new Teacher(){ ID = "002", TeacherName = "老师2", TeacherAge = 32 },
            new Teacher(){ ID = "003", TeacherName = "老师3", TeacherAge = 33 },
            new Teacher(){ ID = "004", TeacherName = "老师4", TeacherAge = 34 },
            new Teacher(){ ID = "005", TeacherName = "老师5", TeacherAge = 35 }
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
        public List<Teacher> GetList()
        {
            Console.WriteLine("GetList-" + DateTime.Now.ToString());
            return list;
        }

        [HttpGet]
        public Teacher GetModel(string id)
        {
            Console.WriteLine("GetModel-" + DateTime.Now.ToString());
            return list.Find(t => t.ID == id);
        }
    }
}