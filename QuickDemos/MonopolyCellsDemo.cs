using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDemos;

public interface CellBuyingable
{
    BuyableCellBahaviour BayingLogic();
}

public class CellThatCanBeBought : CellBuyingable
{
    private BuyableCellBahaviour cellBahaviour;

    public CellThatCanBeBought(int BuyCost)
    {
        cellBahaviour = new BuyableCell(BuyCost);
    }

    public BuyableCellBahaviour BayingLogic()
    {
        return cellBahaviour;
    }
}


public interface BuyableCellBahaviour
{
    void SetCost(int BuyCost);
    int GetCost();
}

public class BuyableCell : BuyableCellBahaviour
{
    private int BuyCost;

    public BuyableCell(int BuyCost)
    {
        this.BuyCost = BuyCost;
    }
    public int GetCost()
    {
        return BuyCost;
    }

    public void SetCost(int BuyCost)
    {
        this.BuyCost = BuyCost;
    }
}

public class NoBuyableCell : BuyableCellBahaviour
{
    public int GetCost()
    {
        return 0;
    }

    public void SetCost(int BuyCost)
    {

    }
}

