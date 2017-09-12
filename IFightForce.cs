namespace AssemblyCSharp
{
    public interface IFightForce
    {
        Commander Commander{ get;}
        Fraction Fraction { get; }
        BattleResult Battle(Army army);
    }
}