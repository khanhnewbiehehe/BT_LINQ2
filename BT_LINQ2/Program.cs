using BT_LINQ2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>
            {
                new Department{Name = "Bo phan 1", Address = "40 Cao Thang, Hai Chau, Da Nang"},
                new Department{Name = "Bo phan 2", Address = "136 Tran Cao Van, Thanh Khe, Da Nang"},
                new Department{Name = "Bo phan 3", Address = "379 Dung Si Thanh Khe, Thanh Khe, Da Nang"}

            };

            List<Position> positions = new List<Position>
            {
                new Position{Name = "Tester", Description = "Kiem thu vien"},
                new Position{Name = "Developer", Description = "Lap trinh vien"},
                new Position{Name = "TeamLead", Description = "Truong nhom"}
            };

            List<Employee> employees = new List<Employee>
            {
                new Employee{Id = 1, Name = "Nguyen Nhat Khanh", Age = 18, Department =  departments[1], Position = positions[1]},
                new Employee{Id = 2, Name = "Nguyen Nhat Khanh", Age = 30, Department = departments[1], Position = positions[0]},
                new Employee{Id = 3, Name = "Nguyen Nhat Khanh", Age = 33, Department = departments[0], Position = positions[2]},
                new Employee{Id = 4, Name = "Nguyen Nhat Khanh", Age = 26, Department = departments[0], Position = positions[1]},
                new Employee{Id = 4, Name = "Nguyen Nhat Khanh", Age = 26, Department = departments[2], Position = positions[2]}
            };

            //Nhập vào từ bàn phím các yêu cầu
            Console.Write("Tu khoa tim kiem: ");
            string TuKhoa = Console.ReadLine();
            Console.Write("Tuoi tu: ");
            int MinAge = int.Parse(Console.ReadLine());
            Console.Write("Den tuoi: ");
            int MaxAge = int.Parse(Console.ReadLine());
            Console.Write("Vi tri: ");
            string ViTri = Console.ReadLine();
            Console.Write("Bo phan: ");
            string PhongBan = Console.ReadLine();

            //Truy vấn từ các yêu cầu đã nhập
            var KetQua = employees.Where(e =>
                         e.Name.Contains(TuKhoa) &&
                         e.Age >= MinAge &&
                         e.Age <= MaxAge &&
                         e.Position.Name.Equals(ViTri) &&
                         e.Department.Name.Equals(PhongBan)
            );

            //In ra kết quả
            Console.WriteLine("Ket qua:");
            foreach (var employee in KetQua)
            {
                Console.WriteLine($"Id: {employee.Id}, Ten: {employee.Name}, Tuoi: {employee.Age}, Bo phan: {employee.Department.Name}, Vi tri: {employee.Position.Name}");
            }
        }
    }
}