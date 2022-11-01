using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToMove : MonoBehaviour
{
    private float _speed;
    private float _distanceToGo;

    private float _currentDistance;

    public float Speed { set { _speed = value; } }
    public float DistanceToGo { set { _distanceToGo = value; } }

    private void Update()
    {
        var moveVelocity = Vector3.right * _speed * Time.deltaTime;
        this.gameObject.transform.Translate(moveVelocity);
        _currentDistance += moveVelocity.magnitude;

        if (_currentDistance >= _distanceToGo)
        {
            if (this.gameObject != null)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
