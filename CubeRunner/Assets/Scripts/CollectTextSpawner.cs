using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTextSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _textPrefab;
    [SerializeField] private Transform _position;

    public void SpawnText()
    {
        Instantiate(_textPrefab, _position);
    }
}
