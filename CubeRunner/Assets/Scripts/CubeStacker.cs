using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerCube))]
public class CubeStacker : MonoBehaviour
{
    [SerializeField] private List<GameObject> _cubes;
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _pickupSound;

    private GameObject _lastCube;
    private PlayerCube _playerCube;
    private ObstacleWall _obstacleWall;

    private void Start()
    {
        UpdateLastCube();
        _playerCube = GetComponent<PlayerCube>();
        _obstacleWall = FindObjectOfType<ObstacleWall>();
    }


    private void UpdateLastCube()
    {
        _lastCube = _cubes[_cubes.Count - 1];
    }


    public void IncreaseCube(GameObject cube)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
        cube.transform.position = new Vector3(transform.position.x, _lastCube.transform.position.y - 1f, transform.position.z);
        cube.transform.SetParent(transform);
        _cubes.Add(cube);
        _animator.SetTrigger("Jump");
        _pickupSound.Play();
        _playerCube.PlayEffect();

        UpdateLastCube();
    }

    public void DecreaseCube(GameObject cube)
    {
        cube.transform.parent = null;
        _cubes.Remove(cube);

        UpdateLastCube();

    }  

}
