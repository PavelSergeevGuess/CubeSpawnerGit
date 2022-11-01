using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField _speedText;
    [SerializeField] private TMP_InputField _distanceText;
    [SerializeField] private TMP_InputField _timeText;

    public void ChangeSpeed()
    {
        if (_speedText == null || _speedText.text.Length <= 0) return;
        var speed = Int32.Parse(_speedText.text);
        GameManager.Instance.ObjectSpeed = speed;
    }

    public void ChangeTimeToSpawn()
    {
        if (_timeText == null || _timeText.text.Length <= 0) return;
        var time = Int32.Parse(_timeText.text);
        GameManager.Instance.TimeToSpawn = time;
    }

    public void ChangeDistance()
    {
        if (_distanceText == null || _distanceText.text.Length <= 0) return;
        var distance = Int32.Parse(_distanceText.text);
        GameManager.Instance.ObjectMoveDistance = distance;
    }
}
