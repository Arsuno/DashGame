using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float stoppingDistance;
    private Transform _target;
    private Score _score;
    private LoseTimer _timer;

    public void Init(Transform player, Score score, LoseTimer timer)
    {
        _target = player;
        _score = score;
        _timer = timer;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, _target.position) > stoppingDistance)
        {
            float step = _speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, step);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<CharacterMovement>())
        {
            Destroy(gameObject);
            _score.AddPoint();
            _timer.AddTime(5);
        }

    }
}
