using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRandomizer<T> where T : DataScriptableObject
{
        void Randomize(T objectToRandomize);
}
