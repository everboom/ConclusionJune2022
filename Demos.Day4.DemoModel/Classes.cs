using System.ComponentModel.DataAnnotations;

namespace Demos.Day4.DemoModel
{
    public class Course
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }
        public string Code { get; set; }

        public Room Room { get; set; }

        public List<Participant> Participants { get; set; }
    }

    public class Room
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string RoomNumber { get; set; }
        public int NumberOfSeats { get; set; }
    }

    public class Participant
    {
        [Key]
        public int Id { get; set; }



        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Course> Courses { get; set; }


    }
}