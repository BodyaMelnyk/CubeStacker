using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackGroundSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _trackGrounds;

    private GameObject _track;
    private float _roadLenght = 30f;

    private void Awake()
    {
        int randomIndex = Random.Range(0, _trackGrounds.Count - 1);
        _track = Instantiate(_trackGrounds[randomIndex], transform.position, Quaternion.identity);
    }


    public void SpawnTrack()
    {
        int randomTrackIndex = Random.Range(0, _trackGrounds.Count);
        Vector3 newPosition = new Vector3(0, 0, _track.transform.position.z + _roadLenght);
        _track = Instantiate(_trackGrounds[randomTrackIndex], newPosition, Quaternion.identity);
    }



}
