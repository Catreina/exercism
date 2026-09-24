public static class PythagoreanTriplet {
  public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum) {

    List<(int a, int b, int c)> triplets = [];
    if (sum % 2 != 0) return triplets;

    for (int a = 1; a < sum / 3; a++) {
      double b = ((double)(square(sum) - (2 * sum * a)) / ((2 * sum) - (2 * a)));
      int c = sum - a - (int)b;
      if (b % 1 == 0 && b > a && c > b) {
        triplets.Add((a, (int)b, c));
      }
    }

    return triplets;
  }

  private static int square(int x) => x * x;
}