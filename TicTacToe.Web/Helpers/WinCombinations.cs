using System.Collections.Generic;

namespace TicTacToe.Web.Helpers
{
    public class WinCombinations
    {
        private readonly List<List<int>> combinations;
        public WinCombinations()
        {
            combinations = new List<List<int>>()
            {
                new List<int>{ 0,1,2 },
                new List<int>{ 3,4,5 },
                new List<int>{ 6,7,8 },
                new List<int>{ 0,3,6 },
                new List<int>{ 1,4,7 },
                new List<int>{ 2,5,8 },
                new List<int>{ 0,4,8 },
                new List<int>{ 2,4,6 }
            };
        }

        public IList<int> GetWinCombitation(IList<int> moves)
        {
            foreach (List<int> combination in combinations)
            {
                bool isFound = true;
                foreach (int location in combination)
                {
                    if (!moves.Contains(location))
                    {
                        isFound = false;
                        break;
                    }
                }

                if (isFound)
                {
                    return combination;
                }
            }

            return null;
        }
    }
}
