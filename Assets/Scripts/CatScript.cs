using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    public enum Value
    {
        VeryLow = -2,
        Low = -1,
        Neutral = 0,
        High = 1,
        VeryHigh = 2,
    }

    public CatsManager.Cat name;
    
    public Value hunger = Value.Neutral;
    public Value thirst = Value.Neutral;
    public bool isSick = false;
    public bool isGone = false;
    
    public Dictionary <CatsManager.Cat, Value> Relations = new Dictionary<CatsManager.Cat, Value>(){
        { CatsManager.Cat.Shadow, Value.Neutral },
        { CatsManager.Cat.Snowflake, Value.Neutral },
        { CatsManager.Cat.Garfield, Value.Neutral },
        { CatsManager.Cat.GarfieldJr, Value.Neutral }
    };

    public Value GetRelations(CatsManager.Cat otherCat)
    {
        return Relations[otherCat];
    }

    public void SetRelations(CatsManager.Cat otherCat, Value relation)
    {
        Relations[otherCat] = relation;
    }
}
