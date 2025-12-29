using System.Threading.Tasks;
using features;
class Program
{
  static async Task Main()
  {
    NullaReferences.Run();
    SwitchExpression.Run();
    InitOnly.Run();
    Record.Run();
    PatternMatching.Run();
    RequiredMember.Run();
  }
}
