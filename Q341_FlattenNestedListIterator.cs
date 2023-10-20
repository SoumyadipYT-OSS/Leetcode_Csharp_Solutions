public class NestedIterator {
       private readonly IList<int> integers;
            private int index = -1;
            public NestedIterator(IList<NestedInteger> nestedList)
            {
              this.integers = this.Fill(nestedList);
            }

            public IList<int> Fill(IList<NestedInteger> nestedList)
            {
                var result = new List<int>();

                foreach (var nestedInteger in nestedList)
                {
                    if (nestedInteger.IsInteger())
                    {
                        result.Add(nestedInteger.GetInteger());
                    }
                    else
                    {
                        result.AddRange(this.Fill(nestedInteger.GetList()));
                    }
                }

                return result;
            }

            public bool HasNext()
            {
                return this.index + 1 < this.integers.Count;
            }

            public int Next()
            {
                return this.integers[++this.index];
            }
}
