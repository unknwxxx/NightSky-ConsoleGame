namespace NightSky.App.Entities.DialogTree
{
    [Serializable]
    public class Option
    {
        public int Index { get; set; }

        public string Value { get; set; }

        public Branch NextBranch { get; set; }

        public Option() { }

        public Option(string value, Branch nextBranch, int index)
        {
            Value = value;
            NextBranch = nextBranch;
            Index = index;
        }
    }
}




