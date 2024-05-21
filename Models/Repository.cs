using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new List<Course>();

        static Repository(){
            _courses = new List<Course>(){
                new Course(){Id=1, Title="AspNet kursu", Description="Güzel bir kurs", Image="1.jpeg",Tags=new string[]{"aspnet","web geliştirme"},isActive=true,isHome=true},
                new Course(){Id=2, Title="Php kursu", Description="Güzel bir kurs",Image="2.jpeg",Tags=new string[]{"php","web geliştirme"},isActive=false,isHome=true},
                new Course(){Id=3, Title="Django kursu", Description="Güzel bir kurs",Image="3.jpeg",Tags=new string[]{"aspnet","web geliştirme"},isActive=true,isHome=false}
            };
        }
        public static List<Course> Courses{
            get { return _courses; }
        }

        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}