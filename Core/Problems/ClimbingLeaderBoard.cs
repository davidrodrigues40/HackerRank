using Core.Helpers;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Core.Problems
{
    public class ClimbingLeaderBoard : IProblem
    {
        private const char _arraySplitter = ' ';
        private Stopwatch? _stopwatch;
        private static ImmutableSortedSet<int>? _currentRanks;


        public void Solve(object input)
        {
            var arrays = input.ToStringArray(_arraySplitter);
            var lists = arrays.ToListOfIntArrays();
            var ranked = lists[0];
            var player = lists[1];
            IEnumerable<int> scores;

            _stopwatch = Stopwatch.StartNew();
            scores = GetRankings(ranked.ToList(), player.ToList());
            Console.WriteLine(String.Join("\n", scores));
            _stopwatch.Stop();
            Console.WriteLine($"New Way: {_stopwatch.Elapsed.TotalMilliseconds}ms");

        }

        private static IEnumerable<int> GetRankings(List<int> ranked, List<int> player)
        {
            _currentRanks = ranked.Distinct().ToImmutableSortedSet();

            var playerRankings = new List<int>();

            foreach (int score in player)
            {
                playerRankings.Add(GetRanking(score));
            }

            return playerRankings;
        }

        private static int GetRanking(int score)
        {

            if (_currentRanks != null && !_currentRanks.Contains(score))
            {
                _currentRanks = _currentRanks.Add(score);
            }

            return _currentRanks != null ? _currentRanks.Count - _currentRanks.IndexOf(score) : 0;
        }

    }
}