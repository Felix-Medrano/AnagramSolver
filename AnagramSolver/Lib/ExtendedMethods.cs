using System.Linq;

namespace AnagramSolver.Lib
{
  public static class ExtendedMethods
  {

    #region Strings
    /// <summary>
    /// Normalizes a string by removing all whitespace and punctuation characters.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string Normalize(this string input)
    {
      if (string.IsNullOrEmpty(input))
        return string.Empty;

      var normalized = new string(input
        .Where(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c))
        .ToArray());

      return normalized;
    }

    /// <summary>
    /// Converts a string to lower case using invariant culture.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToLowCase(this string input)
    {
      if (string.IsNullOrEmpty(input))
        return string.Empty;

      return input.ToLowerInvariant();
    }

    /// <summary>
    /// Sorts the characters in a string in ascending order.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToSort(this string input)
    {
      if (string.IsNullOrEmpty(input))
        return string.Empty;

      var sorted = new string(input.OrderBy(c => c).ToArray());

      return sorted;
    }
    #endregion Strings

  }
}
