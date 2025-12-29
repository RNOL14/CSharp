using System;

namespace features
{
  public class RequiredMember
  {
    public static void Run()
    {
      User user = new User
      {
        Username = "admin"
      };

      Console.WriteLine(user.Username);
    }
  }

  public class User
  {
    public required string Username { get; set; }
  }
}
