public static class PhoneNumber {
  public static (bool IsNY, bool IsFake, string Local) Analyze(string phNum) => 
    (phNum[..3] == "212", phNum[4..7] == "555", phNum[8..]);

  public static bool IsFake((bool bNY, bool bFake, string sLocal) phoneNumberInfo) =>
    phoneNumberInfo.bFake;
}
