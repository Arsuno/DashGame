using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyMovement _enemyMovement;

    private Score _score;
    private LoseTimer _timer;
    private Currency _currency;

    public void Init(Transform target, Score score, LoseTimer timer, Currency currency)
    {
        _enemyMovement.Init(target);
        _score = score;
        _timer = timer;
        _currency = currency;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CharacterMovement>() != null)
        {
            OnDead();
        }

    }
    private void OnDead()
    {
        _score.Add(1);
        _timer.AddTime(5);
        _currency.Add(1);
        Destroy(gameObject);
    }
}
