using introAPI2.Models;

namespace introAPI2.Service
{
    public class StudentsService 
    {
        private AppDbContext _context;

        public StudentsService(AppDbContext context)
        {
            _context = context;
        } 

        /*public Students GetStudents(int id)
        {
            int startIndex = 0;
            int listLength = (int)(_context.Count - 1);
            int index = 0;
            while (startIndex < listLength)
            {
                int mid = (listLength + startIndex) / 2;
                if (_context[mid].StudentId == id)
                {
                    index = mid;
                    break;
                }
                else if (id > _context[mid].StudentId)
                {
                    startIndex = mid - 1;
                }
                else
                {
                    listLength = mid + 1;
                }
            }
            return _context[index];
        }*/

        public short AddStudent (Students student)
        {
           
            _context.Students.Add(student);
            _context.SaveChanges();
            return student.StudentId;
        }

        /*public Students UpdateStudent(int id, Students student)
        {
            int startIndex = 0;
            int listLength = (int)(_context.Count - 1);
            while (startIndex < listLength)
            {
                int mid = (listLength + startIndex) / 2;
                if (_student[mid].StudentId == id)
                {
                    _student[mid] = student;
                    break;
                }
                else if (id > _student[mid].StudentId)
                {
                    startIndex = mid - 1;
                }
                else
                {
                    listLength = mid + 1;
                }
            }
            return student;
        }*/

        /*public int DeleteStudent (int id)
        {
            int startIndex = 0;
            int listLength = (int)(_student.Count - 1);
            while (startIndex < listLength)
            {
                int mid = (listLength + startIndex) / 2;
                if (_student[mid].StudentId == id)
                {
                    _student.RemoveAt(mid);
                    break;
                }
                else if (id > _student[mid].StudentId)
                {
                    startIndex = mid - 1;
                }
                else
                {
                    listLength = mid + 1;
                }
            }
            return id;
        }*/

        public List<Students> GetStudent()
        {
           return _context.Students.ToList();
        }
    }
}
