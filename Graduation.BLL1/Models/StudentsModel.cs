using DataAccessLayer.Helpers;

namespace DataAccessLayer.Entities
{
    public class StudentsModel
    {
        private StudentsModel students;

        public StudentsModel(StudentsModel students)
        {
            this.students = students;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Gender Gender { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public bool Sr { get; set; }
        public int GroupId { get; set; }
    }
}
