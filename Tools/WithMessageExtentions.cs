namespace DomainModelingMadeFunctional.Tools;

// consoleログ出力をメソッドに付加するWithMessage拡張メソッド
public static class WithMessageExtension
{
    public static T WithMessage<T>(this T obj, string message)
    {
        Console.WriteLine(message);
        return obj;
    }
}