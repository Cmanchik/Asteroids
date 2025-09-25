using System.Collections;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.General.Randomizer
{
    public class RandomizerWithWeight
    {
        public static RandomObject GetRandomObject(RandomObject[] objects)
        {
            int totalWeight = objects.Sum(x => x.Weight);
            int randomNumber = Random.Range(0, totalWeight);

            return objects.OrderBy(x => Mathf.Abs(x.Weight - randomNumber)).First();
        }
    }

    public struct RandomObject
    {
        public GameObject Object;
        public int Weight;
    }
}