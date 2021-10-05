using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDisplay : MonoBehaviour
{
    [SerializeField] private Currency _currency;
    [SerializeField] private Text _label;

    private void OnEnable()
    {
        Display();
    }

    private void Display()
    {
        _label.text = _currency.GetValue().ToString();
    }


}
