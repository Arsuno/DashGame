using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour
{
    public event Action Dead;
    
    public void Kill()
    {
        Dead?.Invoke();
        Destroy(gameObject);
    }
}
