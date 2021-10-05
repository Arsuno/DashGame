using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject _shuriken;
    [SerializeField] private int time;

    private void Start()
    {
        StartCoroutine(ShurikenThrowing());
    }
    private IEnumerator ShurikenThrowing()
    {
        GameObject SpawnedShuriken = Instantiate(_shuriken, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(ShurikenThrowing());
        
    }

    
}
