using System.Collections.Generic;
using UnityEngine;

public class CatsManager : MonoBehaviour
{
    public enum Cat
    {
        Shadow,
        Snowflake,
        Garfield,
        GarfieldJr
    }
    public List<CatScript> CatsInspector;
    public Dictionary<Cat, CatScript> Cats;

    void Start()
    {
        foreach (CatScript cat in CatsInspector)
        {
            Cats.Add(cat.name, cat);
        }
    }
    

    public void ChangeRelationship(Cat cat1, Cat cat2, CatScript.Value newStatus)
    {
        Cats[cat1].SetRelations(cat2, newStatus);
        Cats[cat2].SetRelations(cat1, newStatus);
    }
}

