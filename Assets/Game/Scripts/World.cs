using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    [SerializeField] private int _countAnt;
    [SerializeField] private int _countSticky;
    [SerializeField] private Transform _stickyPrefab;
    [SerializeField] private MoveToTarget _antPrefab;
    private List<Transform> _sticks = new();

    private void Start()
    {
        for(int i = 0; i < _countSticky; i++)
        {
            _sticks.Add(Instantiate(_stickyPrefab, new Vector3(Random.Range(-25, 25), 0.05f, Random.Range(-25, 25)), Quaternion.Euler(0, Random.Range(0, 360), 0)));
        }

        for (int i = 0; i < _countAnt; i++)
        {
            var ant = Instantiate(_antPrefab, new Vector3(Random.Range(-25, 25), 0.05f, Random.Range(-25, 25)), Quaternion.identity);
            ant.Target = _sticks[Random.Range(0, _sticks.Count)];
        }
    }

    public Transform GetRandomSticky()
    {
        if(_sticks.Count == 0) return null;
        return _sticks[Random.Range(0, _sticks.Count)];
    }
}