namespace Basic_examples_console;

public class Enum {
    public enum Trees
    {
        Oak = 15,
        Birch = 18,
        Alder = 17,
        Larch = 19
    }

    public class EnumTrees
    {
        public Trees _tree { get; set; }
        public int _treeLength { get; set; }
        
        public EnumTrees(Trees Tree)
        {
            _tree = Tree;
            _treeLength = (int)Tree;

        }
    }
}