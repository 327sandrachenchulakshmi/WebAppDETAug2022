using ODatademo.API.Model;

namespace ODatademo.API.Service
{
    public class StudentService : IStudentService
    {
        public IQueryable<Student> RetrieveAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Vishu Goli",
                    score = 200
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Kailu Hu",
                    score = 160
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Sean Hobbs",
                    score = 170
                }
            }.AsQueryable(); ;
        }
    }
}
