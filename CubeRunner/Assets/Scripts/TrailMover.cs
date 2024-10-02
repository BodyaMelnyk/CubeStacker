using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailMover : MonoBehaviour
{
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _forwardSpeed;
    [SerializeField] private float _limitValueX;

    private float _newPositionX;
    private float _horizontalValue;

    private void Update()
    {
        HandleHorizontalInput();
        MoveForward();
        MoveHorizontal();
    }

    private void HandleHorizontalInput()
    {
        if (Input.GetMouseButton(0))
            _horizontalValue = Input.GetAxis("Mouse X");
        else
            _horizontalValue = 0f;
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.up * _forwardSpeed * Time.deltaTime);
    }

    private void MoveHorizontal()
    {
        _newPositionX = transform.position.x + _horizontalValue * _horizontalSpeed * Time.deltaTime;
        _newPositionX = Mathf.Clamp(_newPositionX, -_limitValueX, _limitValueX);

        transform.position = new Vector3(_newPositionX, transform.position.y, transform.position.z);
    }

    public void Stop()
    {
        enabled = false;
    }
}
