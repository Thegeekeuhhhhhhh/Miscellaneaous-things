// See https://aka.ms/new-console-template for more information

using BordelSubmit;

Console.WriteLine("Hello, World!");

StreamReader test1A = new StreamReader(@"C:\Users\thund\pie-leo.menaldo\EPITA-TPs\S2\C#\miscellaneaous3\Tests\Animal Farm.txt");
EditingText test1B = new EditingText(test1A.ReadToEnd());
test1A.Close();
//Console.WriteLine(test1B);

test1B.ToGitTagFormat(@"C:\Users\thund\pie-leo.menaldo\EPITA-TPs\S2\C#\miscellaneaous3\Tests\AnimalFarmToGitTag.txt");