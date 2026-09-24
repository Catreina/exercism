public static class LineUp {
  public static string Format(string name, int number) =>
    $"{name}, you are the {number}{getOrdinal(number)} customer we serve today. Thank you!";
  

  private static string getOrdinal(int num) {
    int tens = num % 100;
    string ordinal = "th";
 
    if (tens < 10 || tens > 20) {
      switch (tens % 10) {
        case 1:
          ordinal = "st";
          break;
        case 2:
          ordinal = "nd";
          break;
        case 3:
          ordinal = "rd";
          break;
      }
    }
    return ordinal;
  }
}
