/* Closest Prime Numbers in Range */

public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        var lastPrime = -1;
        var bestDiff = int.MaxValue;
        int[] bestPair = [-1, -1];

        if (left <= 2 && right >= 2)
        {
            lastPrime = 2;
            if (right >= 3)
            {
                return [2, 3];
            }
        }

        var candidate = Math.Max(left, 3);
        if (candidate % 2 == 0)
            candidate++;

        while (candidate <= right)
        {
            if (IsPrime(candidate))
            {
                if (lastPrime != -1)
                {
                    var diff = candidate - lastPrime;
                    if (diff == 2)
                        return [lastPrime, candidate];

                    if (diff < bestDiff)
                    {
                        bestDiff = diff;
                        bestPair[0] = lastPrime;
                        bestPair[1] = candidate;
                    }
                }
                lastPrime = candidate;
            }
            candidate += 2;
        }

        return bestPair;
        
        bool IsPrime(long n)
        {
            if (n < 2)
                return false;
            if (n % 2 == 0)
                return n == 2;
            return MillerRabin(n);
        }

        long Binpower(long b, long e, long mod)
        {
            long result = 1;
            b %= mod;
            while (e > 0)
            {
                if ((e & 1) == 1)
                    result = (result * b) % mod;
                b = (b * b) % mod;
                e >>= 1;
            }
            return result;
        }

        bool CheckComposite(long n, long a, long d, int s)
        {
            var x = Binpower(a, d, n);
            if (x == 1 || x == n - 1)
                return false;
            for (var r = 1; r < s; r++)
            {
                x = (x * x) % n;
                if (x == n - 1)
                    return false;
            }
            return true;
        }

        bool MillerRabin(long n)
        {
            if (n < 2)
                return false;
            int[] smallPrimes = [2, 3, 5, 7];
            foreach (var p in smallPrimes)
            {
                if (n == p)
                    return true;
                if (n % p == 0)
                    return false;
            }

            var s = 0;
            var d = n - 1;
            while ((d & 1) == 0)
            {
                d >>= 1;
                s++;
            }
            var witnesses = smallPrimes;
            foreach (var a in witnesses)
            {
                if (CheckComposite(n, a, d, s))
                    return false;
            }
            return true;
        }
    }
}
