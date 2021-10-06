using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float stoppingDistance;
    private Transform _target;
    private Score _score;
    private LoseTimer _timer;
    private Currency _currency;

    public void Init(Transform player)
    {
        _target = player;
        
    }

    private void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        if (Vector2.Distance(transform.position, _target.position) > stoppingDistance)
        {
            float step = _speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, step);
        }
    }

    
}
