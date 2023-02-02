using System;using System.IO;
namespace CountCharacters
{ public class Counter
    { private StreamReader files; private string _path;
        public Counter(string path) { _path = path; }
        public int CharacterCounter() { int temp = 0; string[] directories = Directory.GetDirectories(_path); string[] files = Directory.GetFiles(_path);
            foreach (string s in directories)
            { string[] opened = Directory.GetFiles(s); string[] otherTemp = new string[files.Length + opened.Length];
                for (int i = 0; i < files.Length; i++) { otherTemp[i] = files[i]; }
                for (int i = files.Length; i < files.Length + opened.Length; i++) { otherTemp[i] = opened[i - files.Length]; }
                directories = otherTemp; }
            foreach (string s in directories) { Console.WriteLine(s); }
            foreach (string s in files) { Console.WriteLine(s); }
            foreach (string file in directories) { StreamReader read = new StreamReader(file); string line = read.ReadLine();
                while (line is not null) { temp += line.Length; line = read.ReadLine(); } } return temp; } } }