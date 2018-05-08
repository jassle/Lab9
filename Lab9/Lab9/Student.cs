using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Student
    {
        //Data members
        private string stuName;
        private string stuHmtwn;
        private string stuFavfood;
        private string stuFavcolor;
        private DateTime stuDateofBirth;

    #region Properties
        //Properties
        public string Name
        {
            set // give a value to the name
            { //Validation
                stuName = value; // Value is always on the right side
            }
            get //retrieve the name
            { //Validation
                return stuName;
            }
        }
    public string Hmtwn
        {
            set // give a value to the name
            { //Validation
                stuHmtwn = value; // Value is always on the right side
            }
            get //retrieve the name
            { //Validation
                return stuHmtwn;
            }
        }
    public string FavFood
        {
            set // give a value to the name
            { //Validation
                stuFavfood = value; // Value is always on the right side
            }
            get //retrieve the name
            { //Validation
                return stuFavfood;
            }
        }
    public string FavColor
        {
            set // give a value to the name
            { //Validation
                stuFavcolor = value; // Value is always on the right side
            }
            get //retrieve the name
            { //Validation
                return stuFavcolor;
            }
        }
    public DateTime DateOfBirth
        {
            set // give a value to the name
            { //Validation
                stuDateofBirth = value; // Value is always on the right side
            }
            get //retrieve the name
            { //Validation
                return stuDateofBirth;
            }
            
        }
    public void PrintInfo() // Use Properties ie Name vs stuName
        {
            Console.WriteLine("Student Name: "+Name);
            Console.WriteLine("Student Hometown: "+Hmtwn);
            Console.WriteLine("Student Favorite Food: "+FavFood);
            Console.WriteLine("Student Favorite Color: "+FavColor);
            Console.WriteLine("Student Date of Birth: "+DateOfBirth);
        }
    }
    #endregion
}
/* example of Main 
 
     static void Main(string[] args)
     {
        Student Mike = new Student();
        Mike.Name = "Mike Valda"; //Set
        Console.Writeline(Mike.Name); //Get
        Mike.Hmtwn = "Troy";
        Mike.FavFood = "Pizza";
        Mike.DateofBirth = DateTime.Parse("01/15/1970");

        Mike.PrintInfo();  
    */