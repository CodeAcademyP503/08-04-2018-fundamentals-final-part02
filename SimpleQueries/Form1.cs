using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleQueries
{
    public partial class Form1 : Form
    {
        public int Count = 0;
       
        public List<Student> StudentList = new List<Student>()
        {
            new Student("Elshad","Rustemov",21),
            new Student("Ilkin","Xaniyev",29),
            new Student("Adigozel","Xelilzade",19),
            new Student("Nermin","Rustemova",25),
            new Student("Emrah","Nagiyev",24),
            new Student("Ferid","Gulmemmedov",28),
            new Student("Togrul","Babayev",28),
            new Student("Nicat","Eliyev",29),
            new Student("Turkan","Nesirli",20),
            new Student("Anar","Abishov",27),
            new Student("Tebriz","Bedelov",24),
            new Student("Shahin","Cabbarov",20),
            new Student("Elnur","Soltanov",26),
            new Student("Nicat","Quliyev",24),
            new Student("Nigar","Shukurova",20),
            new Student("Elgiz","Eyvazli",18),
            new Student("Nicat","Sadixov",17),
            new Student("Atilla","Rzazade",15),
        };
        
        
        public Form1()
        {
            InitializeComponent();
            
           
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //  1. Soyadi "Bedelov" olan telebenin Adi ve Yasi
            /*
             var keyword = searchBox.Text;
            foreach (Student item in StudentList)
            {

                if (item.Name == keyword)
                {
                    Result.Text = item.Surname + " - " + item.Age;
                    break;
                }
                else
                {
                    Result.Text = "Bazada bele melumat yoxdur";
                }
            }
            */

            //  2.Adi "Nicat" olan telebelerin sayi
            /*
            foreach (Student item in StudentList)
            {

                if (item.Name == "Nicat")
                {
                    Count++;
                    
                }
               
            }
            Result.Text = Count.ToString();
            */

            //3. Adi "Nicat" olan telebelerden yasi 23 den boyuk olanlarin soyadi ve yasi
            /*
            foreach (Student item in StudentList)
            {

                if (item.Name == "Nicat" && item.Age>23)
                {
                    Result.Text += item.Surname +"\r\n";

                }

            }*/

            // 4.Yasi 24 den boyuk olan telebelerin siyahisi
            /*foreach (Student item in StudentList)
            {

                if (item.Age > 24)
                {
                    Result.Text += item.Name + "\r\n";

                }

            }
            */
            //5.Soyadi en uzun olan telebenin adi
            /* int ageCount = StudentList.Count;
            int[] ages = new int[ageCount];
            for (int i = 0; i < StudentList.Count; i++)
            {
                ages[i] = StudentList[i].Surname.Length;
            }
            foreach (var item in StudentList)
            {
                if (item.Surname.Length == ages.Max())
                {
                    Result.Text = item.Name;
                }
            }
            */
            // 6.Sinifin yas ortalamasi
            /*
            foreach (Student item in StudentList)
            {

                Count += item.Age;

            }
            Result.Text = (Count / StudentList.Count).ToString();
            */
        }


    }
    public class Student
    {
       
        public string Name;
        public string Surname;
        public int Age;
        public Student(string _name,string _surname,int _age)
        {
            Name = _name;
            Surname = _surname;
            Age = _age;
        }
    }

}
