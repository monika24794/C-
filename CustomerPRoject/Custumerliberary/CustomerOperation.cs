using System;

using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Custumerliberary
{
    public  class CustomerOperation

    {
        static Customer[] custolist = new Customer();
        
       
        static CustomerOperation()
        {
            custolist.Add(new Customer(_id: 1, _name: "monika", _city: "pune"));
            custolist.Add(new Customer(2, "nashik", "kajal"));
            custolist.Add(new Customer(3, "hima", "delhi"));

        }
        public void AddCustomer(Customer custo)
        {
            
   
        }
       
    
        public Customer [] GetCustomer()
        {
            return custolist;

        }

    }
}
public class StudentOperation
{
    static Student[] studentList = new Student[3];
    static StudentOperation()
    {
        studentList[0] = new Student(rno: 1, sname: "monika", city: "pune");
        studentList[1] = new Student(2, "nashik", "kajal");
        studentList[2] = new Student(3, "hima", "delhi");

    }
    public void AddStudent(Student student)
    {
        //Student s = new Student(rno: student.rollno,sname:student.Studentname,city:student.city);
        //or
        Student s = new Student();
        studentList.Append(student);
        s.Studentname = student.Studentname;
        s.rollno = student.rollno;
        s.city = student.city;
        studentList.Append(s);
    }
    public void UpdateStudent(Student student) { }
    public void DeleteStudent(Student student) { }

    public Student[] GetStudents()
    {
        return studentList;

    }


