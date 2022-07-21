using System.Diagnostics;

namespace Challenges.C0002_Fibonacci
{
    internal class Module
    {
        private static readonly Dictionary<int, long> _memo = new() { { 0, 0 }, { 1, 1 } };

        public long Fib(int n)
        {
            if (_memo.ContainsKey(n))
                return _memo[n];

            var value = Fib(n - 1) + Fib(n - 2);

            _memo[n] = value;

            return value;
        }
    }
}
