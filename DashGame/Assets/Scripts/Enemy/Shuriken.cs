using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
    [SerializeField] private float _throwspeed;
    private GameObject _target;
    private Rigidbody2D _shurikenRB;

    void Start()
    {
        _target = GameObject.Find("Player");
        _shurikenRB = GetComponent<Rigidbody2D>();
        Vector2 moveDir = (_target.transform.position - transform.position).normalized * _throwspeed;
        _shurikenRB.velocity = new Vector2(moveDir.x, moveDir.y);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.TryGetComponent<Player>(out Player player) == true)
        {
            player.Kill();
            Destroy(gameObject);
        }
    }   
}
