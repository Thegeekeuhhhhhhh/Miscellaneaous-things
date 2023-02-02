namespace BordelSubmit
{
    public class EditingText
    {
        private int _length;
        private string texte;
        public EditingText(string input)
        {
            _length = input.Length;
            texte = input;
        }

        public void ToGitTagFormat(string destination)
        {
            StreamWriter temp =
                new StreamWriter(destination);
            foreach (char c in texte)
            {
                if (c == '?' || c == '~' || c == '^' || c == ':' || c == '*' || c == '[' || c == ']' || c == '@' || c == '\n' || c <= 32 || c == ',')
                {
                    temp.Write('_');
                }
                else
                {
                    temp.Write(c);
                }
            }
            temp.Close();
        }

        public override string ToString()
        {
            return texte;
        }
    }
}