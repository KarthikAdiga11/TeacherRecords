using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Teacher_Records
{
    class TeacherData
    {
        public static void Teachernfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Teacher Information!!!");
            string path = Directory.GetCurrentDirectory();
            string filename = "TeacherRecords.txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("File is not present, creating new file");
            }
            else
            {
                Console.WriteLine("File is Present!!!");
            }
            using (StreamWriter writer = File.CreateText(filename))
            {
                writer.WriteLine("ID: TE01; Name: Raghuram; Class:10; Section:A");
                writer.WriteLine("ID: TE04; Name: Sangeetha; Class:09; Section:A");
                writer.WriteLine("ID: TE06; Name: Anuradha; Class:10; Section:B");
                writer.WriteLine("ID: TE02; Name: Shyam; Class:08; Section:A");
                writer.WriteLine("ID: TE03; Name: Lakshman; Class:09; Section:B");
                writer.WriteLine("ID: TE05; Name: Sanjana; Class:08; Section:B");
            }

            string text = File.ReadAllText(filename);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Teacher Infomation Displayed");

        }
    }
}

