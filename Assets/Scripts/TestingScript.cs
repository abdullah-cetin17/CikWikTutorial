using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    int[] numbers2 = new int[5];
    List<int> numbers3 = new List<int>();
    void Start()
    {
        // numbers2[0] = 1;
        // numbers2[1] = 2;
        // Debug.Log(numbers[3]);
        numbers3.Add(1);
        numbers3.Add(25);
        numbers3.Add(38);
        for (int i = 0; i < numbers3.Count; i++)
        {
            Debug.Log(numbers3[i]);
        }
    }
}
