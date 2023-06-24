using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Str7 : MonoBehaviour
{
    int[] numbers = { 10, 20, 30 };
    void Start()
    {
        numbers[1] = 1;
        Debug.Log(numbers[1]);
    }
}
