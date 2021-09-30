using System;
using System.Collections.Generic;
using System.Text;
public class StudentInfoClass
{
    public delegate long DelegateNumber(long num);
    public delegate string DelegateText(string text);

    public long StudentNo;
    public string Program;
    public string LastName;
    public string FirstName;
    public string MiddleName;
    public long Age;
    public long ContactNo;

    public static string GetFirstName(string FirstName)
    {
        return FirstName;
    }
    public static string GetLastName(string LastName)
    {
        return LastName;
    }
    public static string GetMiddleName(string MiddleName)
    {
        return MiddleName;
    }
    public static string GetAddress(string Address)
    {
        return Address;
    }
    public static string GetProgram(string Program)
    {
        return Program;
    }
    public static long GetAge(long Age)
    {
        return Age;
    }
    public static long GetContactNo(long ContactNo)
    {
        return ContactNo;
    }
    public static long GetStudentNo(long StudentNo)
    {
        return StudentNo;
    }
}



