public static class LogAnalysis {
  public static string SubstringAfter(this string str, string delim) => 
    str[(str.IndexOf(delim) + delim.Length)..];

  public static string SubstringBetween(this string str, string start, string end) => 
    str[(str.IndexOf(start) + start.Length)..^(str.Length - str.IndexOf(end))];
  
  public static string Message(this string str) => str.SubstringAfter("]: ");

  public static string LogLevel(this string str) => str.SubstringBetween("[", "]");

}
