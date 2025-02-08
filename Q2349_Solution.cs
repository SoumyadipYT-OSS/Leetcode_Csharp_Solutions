/* Design a Number Container System */

public class NumberContainers {

     Dictionary<int, int> indexVal;
 Dictionary<int, PriorityQueue<int, int>> numIndex;

    public NumberContainers() {
         indexVal = new Dictionary<int, int>();
 numIndex = new Dictionary<int, PriorityQueue<int, int>>();
    }
    
     public void Change(int index, int number)
  {
      if (indexVal.ContainsKey(index))
      {
          indexVal[index] = number;
      }
      else
      {
          indexVal.Add(index, number);
      }

      if (numIndex.ContainsKey(number))
      {
          numIndex[number].Enqueue(index, index);
      }
      else
      {
          var pq = new PriorityQueue<int, int>();
          pq.Enqueue(index, index);
          numIndex.Add(number, pq);
      }
  }

  public int Find(int number)
  {
      if (numIndex.ContainsKey(number))
      {
          while (numIndex[number].Count > 0)
          {
              int index = numIndex[number].Peek();

              if (indexVal[index] == number) return index;

              numIndex[number].Dequeue();
          }
      }

      return -1;
  }
}

/**
 * Your NumberContainers object will be instantiated and called as such:
 * NumberContainers obj = new NumberContainers();
 * obj.Change(index,number);
 * int param_2 = obj.Find(number);
 */
 
