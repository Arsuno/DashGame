using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _spawnRadius;
    [SerializeField] private float _time;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _player;
    [SerializeField] private Score _score;
    [SerializeField] private LoseTimer _timer;
    [SerializeField] private Currency _currency;

    private void Start()
    {
        StartCoroutine(spawnAnEnemy());
    }
    IEnumerator spawnAnEnemy()
    {
        
        Vector2 spawnPos = _player.transform.position;
        spawnPos += Random.insideUnitCircle.normalized * _spawnRadius;


        Enemy spawnedEnemy = Instantiate(_enemyPrefab, spawnPos, Quaternion.identity);
        spawnedEnemy.Init(_player, _score, _timer, _currency);
        yield return new WaitForSeconds(_time);

        StartCoroutine(spawnAnEnemy());
    }

}
