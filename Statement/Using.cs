using System;
using System.IO;

class Using
{
  static void Main()
  {
    WriteCharacters();
  }

  static async void WriteCharacters()
  {
    using (StreamWriter writer = File.CreateText("using-newfile.txt"))
    {
      await writer.WriteLineAsync("First line of example");
      await writer.WriteLineAsync("and second line");
    }
  }
}
