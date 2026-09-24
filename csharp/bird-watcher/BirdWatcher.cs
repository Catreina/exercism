class BirdCount {
  private int[] _birdsPerDay;
  private static int[] _lastWeek = new int[] {0, 2, 5, 3, 7, 8, 4};
  public BirdCount(int[] birdsPerDay) => _birdsPerDay = birdsPerDay;
  public static int[] LastWeek() => _lastWeek;
  public int Today() => _birdsPerDay.Last();
  public void IncrementTodaysCount() => _birdsPerDay[^1]++;
  public bool HasDayWithoutBirds() => _birdsPerDay.Contains(0);
  public int CountForFirstDays(int numberOfDays) => _birdsPerDay[0..numberOfDays].Sum();
  public int BusyDays() => _birdsPerDay.Count(day => day >= 5);
}