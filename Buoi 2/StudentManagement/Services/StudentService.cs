using StudentManagement.Models;

namespace StudentManagement.Services;

// Module quan ly sinh vien trong 1 lop
public class StudentService
{
    private readonly ClassSubject _classSubject;

    public StudentService(ClassSubject classSubject)
    {
        _classSubject = classSubject;
    }

    public void Add(string stdId, string name, double midPoint, double finalPoint)
    {
        _classSubject.AddStudent(new Student(stdId, name, midPoint, finalPoint));
    }

    public bool Delete(string stdId) => _classSubject.RemoveStudent(stdId);

    public bool UpdatePoint(string stdId, double midPoint, double finalPoint)
    {
        var s = _classSubject.FindStudent(stdId);
        if (s == null) return false;
        s.MidPoint = midPoint;
        s.FinalPoint = finalPoint;
        return true;
    }

    public List<Student> GetPassed() =>
        _classSubject.Students.Where(s => s.IsPassed()).ToList();

    public List<Student> GetTop(int n) =>
        _classSubject.Students.OrderByDescending(s => s.Average).Take(n).ToList();

    public List<Student> SearchByName(string keyword) =>
        _classSubject.Students
            .Where(s => s.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();
}
