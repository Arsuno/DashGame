using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    private uint _value = 2;

    public void Add(uint value)
    {
        _value += value;
    }

    public void Withdraw(uint value)
    {
        _value -= value;
    } 

    public uint GetValue()
    {
        return _value;
    }
}
