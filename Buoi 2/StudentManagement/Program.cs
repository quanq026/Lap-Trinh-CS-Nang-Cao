using StudentManagement.Models;
using StudentManagement.Services;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Demo du lieu mau
var lop1 = new ClassSubject("CS101", "Lap trinh C#", "Thay An", "HK1-2026");
var studentService = new StudentService(lop1);
var classService = new ClassSubjectService();

classService.AddClass(lop1);

studentService.Add("SV001", "Nguyen Van A", 8.0, 9.0);
studentService.Add("SV002", "Tran Thi B", 6.5, 7.0);
studentService.Add("SV003", "Le Van C", 4.0, 3.5);

var lop2 = new ClassSubject("CS102", "Co so du lieu", "Co Binh", "HK1-2026");
lop2.AddStudent(new Student("SV004", "Pham Van D", 9.0, 8.5));
classService.AddClass(lop2);

// Menu console nho
while (true)
{
    Console.WriteLine("\n===== QUAN LY SINH VIEN =====");
    Console.WriteLine("1. Xem tat ca lop");
    Console.WriteLine("2. Xem chi tiet lop CS101");
    Console.WriteLine("3. Xem SV dau / Top 2");
    Console.WriteLine("4. Tim SV theo ten");
    Console.WriteLine("0. Thoat");
    Console.Write("Chon: ");
    var chon = Console.ReadLine();

    if (chon == "0") break;

    switch (chon)
    {
        case "1":
            classService.PrintAll();
            break;
        case "2":
            lop1.PrintInfo();
            break;
        case "3":
            Console.WriteLine("-- SV dau --");
            foreach (var s in studentService.GetPassed())
                Console.WriteLine(s);
            Console.WriteLine("-- Top 2 --");
            foreach (var s in studentService.GetTop(2))
                Console.WriteLine(s);
            break;
        case "4":
            Console.Write("Nhap ten can tim: ");
            var kw = Console.ReadLine() ?? "";
            foreach (var s in studentService.SearchByName(kw))
                Console.WriteLine(s);
            break;
        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }
}
