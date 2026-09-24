static class LogLine {

  public static string Message(string logLine) => 
    logLine.Substring(logLine.IndexOf(" ")).Trim();
  

  public static string LogLevel(string logLine) {
    string level = logLine.Substring(0, logLine.IndexOf(" ")).Trim();
    return level.Replace("]:", "").Replace("[", "").ToLower();    
  }

  public static string Reformat(string logLine) => 
    $"{Message(logLine)} ({LogLevel(logLine).ToLower()})";
}

