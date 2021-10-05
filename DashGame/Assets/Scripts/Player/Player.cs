using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public event Action Dead;

    public void Kill()
    {
        Destroy(gameObject);
        Dead?.Invoke();
    }
}
