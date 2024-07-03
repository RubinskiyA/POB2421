using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31._1
{
    public class ClassFileManager
    {
        public static string Reader(string filePath)=>File.ReadAllText(filePath);
        public static void Writer(string filePath,string text)=>File.WriteAllText(filePath, text); 
        public static bool Exist(string filePath)=>File.Exists(filePath);
        public static void Delete(string filePath)=>File.Delete(filePath);
        public static void Create(string filePath)=>File.Create(filePath);
    }
}
