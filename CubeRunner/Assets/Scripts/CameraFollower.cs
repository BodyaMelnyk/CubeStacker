using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _lerpValue;

    private Vector3 _offset;
    private Vector3 _newPosition;

    private void Start()
    {
        _offset = transform.position - _player.position;
    }

    private void LateUpdate()
    {
        CameraSmoothFollow();
    }

    private void CameraSmoothFollow()
    {
        _newPosition = Vector3.Lerp(transform.position, new Vector3(0f, _player.position.y, _player.position.z)
                                                                                          + _offset, _lerpValue * Time.deltaTime);
        transform.position = _newPosition;
    }
}
