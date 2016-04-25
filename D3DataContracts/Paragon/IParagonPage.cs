namespace D3DataContracts.Paragon
{
    public interface IParagonPage
    {
        string PageName { get; }
        ParagonStat stat1 { get; }
        ParagonStat stat2 { get; }
        ParagonStat stat3 { get; }
        ParagonStat stat4 { get; }
        int ActualMaxPoints { get; }

    }
}