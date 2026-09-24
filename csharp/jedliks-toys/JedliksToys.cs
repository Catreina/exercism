class RemoteControlCar (int i = 0) {
  public static RemoteControlCar Buy() => new();
  public string DistanceDisplay() => $"Driven {i * 20} meters";
  public string BatteryDisplay() => $"Battery {((i == 100) ? "empty" : $"at {100 - i}%")}";
  public void Drive() => i += (i < 100 ? 1 : 0);
}
