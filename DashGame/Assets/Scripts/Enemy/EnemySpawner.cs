using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _spawnRadius;
    [SerializeField] private float _time;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _player;
    [SerializeField] private Score _score;
    [SerializeField] private LoseTimer _loseTimer;
    

    private void Start()
    {
        StartCoroutine(spawnAnEnemy());
    }
    IEnumerator spawnAnEnemy()
    {
        Vector2 spawnPos = _player.transform.position;
        spawnPos += Random.insideUnitCircle.normalized * _spawnRadius;


        GameObject spawnedEnemy = Instantiate(_enemy, spawnPos, Quaternion.identity);
        spawnedEnemy.GetComponent<EnemyController>().Init(_player, _score, _loseTimer);
        yield return new WaitForSeconds(_time);

        StartCoroutine(spawnAnEnemy());
    }

}
