using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPlayground
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public Dictionary<string,int> Scores;
        public static List<Student> GetStudents()
        {
            return new List<Student>{
    new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new Dictionary<string,int> { {"Maths",97 }, {"Science", 92 }, {"Bio", 81}, {"Social", 60 } } },
    new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new Dictionary<string,int> { { "Maths", 75 }, { "Science", 84 }, { "Bio", 91 }, { "Social", 39 } }},
    new Student {First="Sven", Last="Mortensen", ID=113, Scores= new Dictionary<string,int> { { "Maths", 88 }, { "Science", 94 }, { "Bio", 65 }, { "Social", 91 } }},
    new Student {First="Cesar", Last="Garcia", ID=114, Scores= new Dictionary<string,int> { { "Maths", 97 }, { "Science", 89 }, { "Bio", 85 }, { "Social", 82 } }},
    new Student {First="Debra", Last="Garcia", ID=115, Scores= new Dictionary<string,int> { { "Maths", 35 }, { "Science", 72 }, { "Bio", 91 }, { "Social", 70 } }},
    new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new Dictionary<string,int> { { "Maths", 99 }, { "Science", 86 }, { "Bio", 90 }, { "Social", 94 } }},
    new Student {First="Hanying", Last="Feng", ID=117, Scores= new Dictionary<string,int> { { "Maths", 93 }, { "Science", 92 }, { "Bio", 80 }, { "Social", 87 } }},
    new Student {First="Hugo", Last="Garcia", ID=118, Scores= new Dictionary<string,int> { { "Maths", 92 }, { "Science", 90 }, { "Bio", 83 }, { "Social", 78 } }},
    new Student {First="Lance", Last="Tucker", ID=119, Scores= new Dictionary<string,int> { { "Maths", 68 }, { "Science", 79 }, { "Bio", 88 }, { "Social", 92 } }},
    new Student {First="Terry", Last="Adams", ID=120, Scores= new Dictionary<string,int> { { "Maths", 99 }, { "Science", 82 }, { "Bio", 81 }, { "Social", 79 } }},
    new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new Dictionary<string,int> { { "Maths", 96 }, { "Science", 85 }, { "Bio", 91 }, { "Social", 60 } }},
    new Student {First="Michael", Last="Tucker", ID=122, Scores= new Dictionary<string,int> { { "Maths", 94 }, { "Science", 92 }, { "Bio", 91 }, { "Social", 91 } }},
    new Student {First="Michael", Last="Fastbender", ID=122, Scores= new Dictionary<string,int> { { "Maths", 94 }, { "Science", 92 }, { "Bio", 91 }, { "Social", 91 } }}
};
        }
    }
}
