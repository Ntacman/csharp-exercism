using System;

public class Robot
{
    string name;

    public static string GetName()
    {
        var rand_char = new Random();
        char[] c = new char[5];
        c[0] = (char)rand_char.Next(65, 90);
        c[1] = (char)rand_char.Next(65, 90);
        c[2] = (char)rand_char.Next(48, 57);
        c[3] = (char)rand_char.Next(48, 57);
        c[4] = (char)rand_char.Next(48, 57);
        return new string(c);
    }

    public string Name
    {
        get
        {
          return this.name;
        }
        set
        {
          this.name = value;
        }
    }

    public Robot()
    {
      this.Name = GetName();
    }

    public void Reset()
    {
        this.Name = GetName();
    }
}
