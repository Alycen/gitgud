using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataRandomizer : IRandomizer<DataScriptableObject>
{
    public void Randomize(DataScriptableObject objectToRandomize)
    {
        objectToRandomize.name = "Random" + Random.Range(0,100);

        objectToRandomize.agility = Random.Range(0,555);
        objectToRandomize.consitution = Random.Range(0,555);
        objectToRandomize.strength = Random.Range(0,555);
        objectToRandomize.speed = Random.Range(0,555);
    }
}
    
