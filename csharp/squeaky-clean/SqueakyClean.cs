using System.Text;
public static class Identifier {
  public static string Clean(string identifier) {
    if (identifier == "") return "";
    StringBuilder sb = new StringBuilder();
    bool bUpper = false;
    for (int x = 0; x < identifier.Length; x++) {
      Char ch = identifier[x];
      if (bUpper) { bUpper = false; sb.Append(char.ToUpper(ch)); continue; }
      if (ch == ' ') { sb.Append('_'); continue; }
      if (char.IsControl(ch)) { sb.Append("CTRL"); continue; }
      if (ch == '-') { bUpper = true; continue; }
      if (!char.IsLetter(ch)) { continue; }
      if (ch >= 'α' && ch <= 'ω') { continue; }
      sb.Append(ch);      
    }
    return sb.ToString();
  }
}