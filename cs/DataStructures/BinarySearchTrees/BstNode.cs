namespace bst
{
  class BstNode
  {
    public int Value { get; set; }
    public BstNode Left { get; set; }
    public BstNode Right { get; set; }

    public BstNode(int value)
    {
      Value = value;
    }
  }
}
