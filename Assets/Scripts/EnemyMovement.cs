using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _speed;

    private int _currentPoint = 0;

    private void Update()
    {
        if (transform.position == _wayPoints[_currentPoint].position)
            _currentPoint = (_currentPoint + 1) % _wayPoints.Length;

        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentPoint].position, _speed * Time.deltaTime);
    }

    public void SetWayPoints(Transform[] wayPoints)
    {
        _wayPoints = wayPoints;
    }
}
