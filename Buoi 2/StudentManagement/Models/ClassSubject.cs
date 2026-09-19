namespace StudentManagement.Models;

// Lop ClassSubject: Id, Name, Teacher, List<Student>, Semester
public class ClassSubject
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Teacher { get; set; } = string.Empty;
    public string Semester { get; set; } = string.Empty;
    public List<Student> Students { get; set; } = new();

    public ClassSubject() { }

    public ClassSubject(string id, string name, string teacher, string semester)
    {
        Id = id;
        Name = name;
        Teacher = teacher;
        Semester = semester;
    }

    public void AddStudent(Student student)
    {
        if (Students.Any(s => s.StdId == student.StdId))
            throw new InvalidOperationException($"Sinh vien ma {student.StdId} da ton tai.");
        Students.Add(student);
    }

    public bool RemoveStudent(string stdId)
    {
        var s = FindStudent(stdId);
        if (s == null) return false;
        return Students.Remove(s);
    }

    public Student? FindStudent(string stdId)
    {
        return Students.FirstOrDefault(s =>
            s.StdId.Equals(stdId, StringComparison.OrdinalIgnoreCase));
    }

    public bool updatestudent(Student student)
    {
        var existingStudent = getstudentbyid(student.StdId);
        if (existingStudent == null) return false;

        existingStudent.Name = student.Name;
        existingStudent.MidPoint = student.MidPoint;
        existingStudent.FinalPoint = student.FinalPoint;
        return true;
    }

    public Student? getstudentbyid(string stdId)
    {
        return Students.FirstOrDefault(s =>
            s.StdId.Equals(stdId, StringComparison.OrdinalIgnoreCase));
    }

    public List<Student> getstudentbyname(string name)
    {
        return Students
            .Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public double ClassAverage()
    {
        if (Students.Count == 0) return 0;
        return Students.Average(s => s.Average);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"=== Lop HP [{Id}] {Name} ===");
        Console.WriteLine($"GV: {Teacher} | Hoc ky: {Semester} | Si so: {Students.Count} | TB lop: {ClassAverage():F2}");
        foreach (var s in Students)
            Console.WriteLine("  - " + s);
    }

    public override string ToString()
    {
        return $"[{Id}] {Name} - GV: {Teacher} - HK: {Semester} - Si so: {Students.Count}";
    }

    public List<Student> getStudentMidPointPLusOne(){
        Students.ForEach(s => s.MidPoint += 1);
        return Students;
    }
}
