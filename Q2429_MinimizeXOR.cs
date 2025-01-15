public class Solution {
    public int MinimizeXor(int num1, int num2) {
        int countSetBits = CountSetBits(num2);

        int x = 0;

        for (int i=30; i>=0; i--) {
            if ((num1 & (1 << i)) != 0) {
                if (countSetBits > 0) {
                    x |= (1 << i);
                    countSetBits--;
                }
            }
        }


        for (int i=0; i<31 && countSetBits > 0; ++i) {
            if ((x & (1 << i)) == 0) {
                x |= (1 << i);
                countSetBits--;
            }
        }

        return x;
    }



    private int CountSetBits(int num) {
        int count = 0;
        while (num > 0) {
            count += num & 1;
            num >>= 1;
        }

        return count;
    }
}
