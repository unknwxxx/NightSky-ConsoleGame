namespace NightSky.App.Entities.DialogTree
{
    [Serializable]
    public class DialogTree
    {
        private Branch _root;

        private List<Branch> _branches;

        public Branch Root
        {
            get => _root;
            set
            {
                _root = value;
                _branches.Add(value);
            }
        }

        public List<Branch> Branches 
        { 
            get => _branches; 
            set => _branches = value; 
        }

        public DialogTree(Branch root, List<Branch> branches)
        {
            _root = root;
            _branches = branches;
        }

        public DialogTree()
        {
            _root = new Branch();
            _branches = new List<Branch>();
        }

    }
}




