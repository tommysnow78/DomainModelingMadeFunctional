using DomainModelingMadeFunctional.Tools;

namespace DomainModelingMadeFunctional.Domains;

public record 卵(int 個数);
public class ゆで卵;
public class 生卵;
public class 溶き卵;
public class 目玉焼き;
public class オムレツ;

public static class 調理
{
    public static 卵 用意する(int 個数) => new 卵(個数).WithMessage($"{個数}個の卵を用意しました");
    public static 生卵 割る(this 卵 _) => new 生卵().WithMessage("卵を割りました");
    public static 溶き卵 溶く(this 生卵 _) => new 溶き卵().WithMessage("生卵を溶きました");
    public static ゆで卵 ゆでる(this 卵 _) => new ゆで卵().WithMessage("卵をゆでました");
    public static 目玉焼き 焼く(this 生卵 _) => new 目玉焼き().WithMessage("生卵を焼きました");
    public static オムレツ 焼く(this 溶き卵 _) => new オムレツ().WithMessage("溶き卵を焼きました");
}