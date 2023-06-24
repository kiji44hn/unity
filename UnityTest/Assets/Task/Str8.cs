using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Str8 : MonoBehaviour
{
    int[] numbers = { 10, 20, 30, 1, 2, 33, -33, 44, 556, 54345, 3434 };
    void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}
