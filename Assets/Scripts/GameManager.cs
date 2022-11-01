using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float _timeToSpawn = 2;
    [SerializeField] private float _objectSpeed = 1;
    [SerializeField] private float _objectMoveDistance = 7;

    private float _timeSinceLastSpawn;

    [SerializeField] private GameObject _cubePrefab;

    public float TimeToSpawn { set { _timeToSpawn = value; } }
    public float ObjectSpeed { set { _objectSpeed = value; } }
    public float ObjectMoveDistance { set { _objectMoveDistance = value; } }

    #region Singleton
    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    private void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;
        if (_timeSinceLastSpawn >= _timeToSpawn)
        {
            _timeSinceLastSpawn = 0;
            SpawnCube();
        }
    }

    private void SpawnCube()
    {
        var cubePrefab = Instantiate(_cubePrefab);
        cubePrefab.transform.position = Vector3.zero;
        var cube = cubePrefab.GetComponent<ObjectToMove>();
        cube.Speed = _objectSpeed;
        cube.DistanceToGo = _objectMoveDistance;
    }
}
