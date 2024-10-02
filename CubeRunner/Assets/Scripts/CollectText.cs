using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CollectText : MonoBehaviour
{
    [SerializeField] private float _verticalSpeed = 5f;
    [SerializeField] private float _horizontalSpeed = 10f;

    private Rigidbody _rigidbody;
    private Vector3 _direction;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rigidbody.AddForce(transform.up * _verticalSpeed, ForceMode.Impulse);
        _rigidbody.velocity = -transform.forward * _horizontalSpeed;

        StartCoroutine(DisablePhysics());
    }

    private IEnumerator DisablePhysics()
    {
        yield return new WaitForSeconds(2f);
        _rigidbody.velocity = Vector3.zero;
        gameObject.SetActive(false);
    }
}
