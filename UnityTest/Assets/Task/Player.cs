﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    int hp;

    public void Attack()
    {
        Debug.Log("攻撃");
    }

    public void Damage(int damage)
    {
        hp -= damage;
        Debug.Log(hp);
    }
}