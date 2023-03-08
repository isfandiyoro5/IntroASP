using introAPI2.Models;

namespace introAPI2.Service
{
    public interface IStudentsService
    {
        public Students GetStudent(int id);
        public short AddStudent(Students student);
        public Students UpdateStudent(int id, Students student);
        public int DeleteStudent(int id);
    }
}
