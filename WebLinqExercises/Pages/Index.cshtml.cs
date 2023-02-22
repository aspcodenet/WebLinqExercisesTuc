using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebLinqExercises.Pages
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //public Student(int id, string name, int age)
        //{
        //    Id = id;
        //}
    }


    //public class StudentWithOnlyNameAndAge
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}



    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //var a = new Student();
            //a.Age = 42;
            //a.Id = 1;
            //a.Name = "Lisa";

            var a = new Student
            {
                Age = 12,
                Id=11 ,
                Name = "Karl Bertil"
            };

            var bb = new Student
            {
                Age = 13,
                Id = 10,
                Name = "Nisse"
            };

            var bbc = new Student
            {
                Age = 14,
                Id = 1,
                Name = "Lisa"
            };
            var listan = new List<Student>();
            listan.Add(a);
            listan.Add(bb);
            listan.Add(bbc);

            var result = listan.Select(oneStudent => new { Age=oneStudent.Age, Name = oneStudent.Name}).ToList();


            var result2 = listan.Where(oneStudent=>oneStudent.Age > 19).Select(oneStudent => new
            {
                Name = oneStudent.Name ,
                NameLength = oneStudent.Name.Length
            }).OrderBy(e=>e.Name).ToList();


            int i;
            i=12345;


            //Skapa en ny lista med Stduenternas Namn och Age


            //var l = new List<Student>
            //{
            //    a, bb, bbc
            //};


            var inputten = "300 12 187";
            var alla = inputten.Split(' ').Select(p=>Convert.ToInt32(p)).Where(p => p > 100);

            


            Console.WriteLine(a.Age);
            if (a.Id == 11)
            {
                a.Name = "Kalle Nilsson";
            }

            var b = new
            {
                Age = 12,
                Id = 11,
                Name = "321231",
                Courses = new []
                {
                    new {Name="ASP.NET", Id=12334, Grade="VG"},
                    new {Name="Javascript", Id=1234, Grade="VG"}
                }
            };


        }
    }
}