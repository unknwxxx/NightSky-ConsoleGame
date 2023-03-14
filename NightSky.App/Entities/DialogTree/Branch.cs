namespace NightSky.App.Entities.DialogTree
{
    [Serializable]
    public class Branch
    {
        public bool IsWaiting { get; private set; }
        public string Text { get; set; }
        public List<Option> Content { get; set; }

        public Branch()
        {
            Content = new List<Option>();
        }
        public Branch(string text)
        {
            Text = text;
            Content = new List<Option>();
        }

        public Branch AddOption(string optionText, Branch nextBranch, int index)
        {
            Content.Add(new Option(optionText, nextBranch, index));
            return this;
        }
        public Branch RemoveOption(int index)
        {
            Content = Content.Where((c, i) => i != index).ToList();
            return this;
        }

        public Branch AddWaiting()
        {
            IsWaiting = true;
            return this;
        } 
    }
}




