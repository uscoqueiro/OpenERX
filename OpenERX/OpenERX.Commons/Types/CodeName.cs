namespace OpenERX.Commons.Types
{
    public class CodeName
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public CodeName()
        {
        }

        public CodeName(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

    }
}



