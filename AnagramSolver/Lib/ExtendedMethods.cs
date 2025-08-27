using System.Linq;

namespace AnagramSolver.Lib
{
  public static class ExtendedMethods
  {

    #region Strings

    /// <summary>
    /// Converts a string to lower case using invariant culture.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToLowCase(this string input)
    {
      return input.ToLowerInvariant();
    }

    /// <summary>
    /// Sorts the characters in a string in ascending order.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToSort(this string input)
    {
      var sorted = new string(input.OrderBy(c => c).ToArray());

      return sorted;
    }

    /// <summary>
    /// Remove numbers from text
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string RemoveNumbers(this string input)
    {
      return new string(input
        .Where(c => !char.IsDigit(c))
        .ToArray());
    }

    #endregion Strings

  }
}
