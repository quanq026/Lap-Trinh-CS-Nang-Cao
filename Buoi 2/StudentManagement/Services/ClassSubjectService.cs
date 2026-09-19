using StudentManagement.Models;

namespace StudentManagement.Services;

// Module quan ly nhieu lop hoc phan
public class ClassSubjectService
{
    public List<ClassSubject> Classes { get; } = new();

    public void AddClass(ClassSubject c)
    {
        if (Classes.Any(x => x.Id == c.Id))
            throw new InvalidOperationException($"Lop {c.Id} da ton tai.");
        Classes.Add(c);
    }

    public bool RemoveClass(string id)
    {
        var c = FindClass(id);
        if (c == null) return false;
        return Classes.Remove(c);
    }

    public ClassSubject? FindClass(string id)
    {
        return Classes.FirstOrDefault(x =>
            x.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
    }

    public void PrintAll()
    {
        if (Classes.Count == 0)
        {
            Console.WriteLine("Chua co lop hoc phan nao.");
            return;
        }
        foreach (var c in Classes)
            Console.WriteLine(c);
    }
}
