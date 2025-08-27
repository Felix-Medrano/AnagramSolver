using System.Linq;

namespace AnagramSolver.Lib
{
  public class ASFunctions
  {
    public string Normalize(string input)
    {
      return new string(input
        .Where(c => char.IsLetter(c))
        .ToArray());
    }
  }
}
