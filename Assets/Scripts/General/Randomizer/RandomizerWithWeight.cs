using System;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts.General.Randomizer
{
    public class RandomizerWithWeight
    {
        public static ObjectWithWeight GetRandomObject(ObjectWithWeight[] objects)
        {
            int totalWeight = objects.Sum(x => x.Weight);
            int randomNumber = Random.Range(0, totalWeight);

            return objects.OrderBy(x => Mathf.Abs(x.Weight - randomNumber)).First();
        }
    }


    [Serializable]
    public struct ObjectWithWeight
    {
        public GameObject Object;
        public int Weight;
    }
}