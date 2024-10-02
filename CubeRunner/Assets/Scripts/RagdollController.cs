using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _allRigidbodies;
    [SerializeField] private Animator _animator;

    private void Awake()
    {
        for (int i = 0; i < _allRigidbodies.Length; i++)
        {
            _allRigidbodies[i].isKinematic = true;
        }
    }


    public void EnableRagdoll()
    {
        _animator.enabled = false;
        for (int i = 0; i < _allRigidbodies.Length; i++)
        {
            _allRigidbodies[i].isKinematic = false;
        }
    }   
}
