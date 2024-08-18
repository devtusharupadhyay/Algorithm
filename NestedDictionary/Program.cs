using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

var students = new Dictionary<string, Dictionary<string, int>>
{
    { "Mani", new Dictionary<string, int> { { "Physics", 100 }, { "Chemistry", 98 }, { "Maths", 95 } } },
    { "Ezhil", new Dictionary<string, int> { { "Physics", 95 }, { "Chemistry", 100 }, { "Maths", 83 } } },
    { "Murugan", new Dictionary<string, int> { { "Physics", 55 }, { "Chemistry", 77 }, { "Maths", 99 } } }
};

var eligibleStudents = students
    .Where(student => student.Value.TryGetValue("Physics", out int physicsMarks) && physicsMarks > 60
                   && student.Value.TryGetValue("Chemistry", out int chemistryMarks) && chemistryMarks > 60
                   && student.Value.TryGetValue("Maths", out int mathMarks) && mathMarks > 60)
    .Select(student => student.Key);

foreach (var student in eligibleStudents)
{
    Console.WriteLine(student);
}
//Filter only items that got above 60 in all subjects