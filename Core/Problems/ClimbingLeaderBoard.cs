using Core.Helpers;
using System.Collections.Immutable;

namespace Core.Problems
{
    public class ClimbingLeaderBoard : IProblem
    {
        private const char _arraySplitter = ' ';
        private static ImmutableSortedSet<int>? _currentRanks;


        public object Solve(object input)
        {
            var arrays = input.ToStringArray(_arraySplitter);
            var lists = arrays.ToListOfIntArrays();
            var ranked = lists[0];
            var player = lists[1];
            IEnumerable<int> scores;

            scores = GetRankings(ranked.ToList(), player.ToList());

            return string.Join("\n", scores);

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