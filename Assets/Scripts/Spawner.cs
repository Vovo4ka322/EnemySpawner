using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMovement _enemyMovement;
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _appearanceTime;
    
    private void OnEnable()
    {
        Invoke(nameof(Spawn), _appearanceTime);
    }

    private void Spawn()
    {
        EnemyMovement gameObject = Instantiate(_enemyMovement);
        gameObject.transform.position = transform.position;

        gameObject.SetWayPoints(_wayPoints);

        Invoke(nameof(Spawn), _appearanceTime);       
    }    
}