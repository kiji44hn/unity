using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Str4 : MonoBehaviour
{
    readonly int x = 1;
    readonly int y = 2;
    readonly int z = 5;

    // Start is called before the first frame update
    void Start()
    {
        // 1+2をおこなってから5をかけて、コンソールに15を表示
        Debug.Log((x + y) * z);
    }
}
