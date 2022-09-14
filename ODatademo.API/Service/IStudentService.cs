using ODatademo.API.Model;

namespace ODatademo.API.Service
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}
