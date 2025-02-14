/* Product of the Last K Numbers */

public class ProductOfNumbers {
    private int[] buffer = new int[100001];
    private int index;

    private void Init() {
        index = 0;
        buffer[index] = 1;        
    }

    public ProductOfNumbers() {
        Init();
    }    
    
    public void Add(int num) {
        if (num == 0) {
            Init();
        } else {
            index++;
            buffer[index] = buffer[index - 1] * num;
        }
    }
    
    public int GetProduct(int k) {
        if (k > index) {
            return 0;
        }

        return buffer[index] / buffer[index - k];
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */
 
