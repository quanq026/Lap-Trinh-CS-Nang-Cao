namespace StudentManagement.Models;

// Lop Student: StdId, Name, MidPoint, FinalPoint
public class Student
{
    public string StdId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public double MidPoint { get; set; }
    public double FinalPoint { get; set; }

    public Student() { }

    public Student(string stdId, string name, double midPoint, double finalPoint)
    {
        StdId = stdId;
        Name = name;
        MidPoint = midPoint;
        FinalPoint = finalPoint;
    }

    // Diem trung binh = (giua ky + cuoi ky) / 2
    public double Average => (MidPoint + FinalPoint) / 2.0;

    public bool IsPassed() => Average >= 5.0;

    public string GetGrade()
    {
        if (Average >= 8.5) return "A";
        if (Average >= 7.0) return "B";
        if (Average >= 5.5) return "C";
        if (Average >= 4.0) return "D";
        return "F";
    }

    public override string ToString()
    {
        return $"[{StdId}] {Name} - GiuaKy: {MidPoint:F1}, CuoiKy: {FinalPoint:F1}, TB: {Average:F2}, XepLoai: {GetGrade()}";
    }
}
