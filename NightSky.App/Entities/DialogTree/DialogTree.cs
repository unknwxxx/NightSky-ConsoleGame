namespace NightSky.App.Entities.DialogTree
{
    [Serializable]
    public class DialogTree
    {
        private Branch _root;

        public event Action<Branch> BranchInfoSaved;

        public Branch Root
        {
            get => _root;
            set
            {
                _root = value;
                BranchInfoSaved?.Invoke(value);
            }
        }

        public DialogTree() => _root = new Branch();
        public DialogTree(Branch root) => _root = root;

        private void SaveBranchInfo(Branch branch)
        {
            if(branch != null)
            {
                BranchInfoSaved?.Invoke(branch);
                SaveBranchInfo(branch);
            }
            
        }
    }
}




