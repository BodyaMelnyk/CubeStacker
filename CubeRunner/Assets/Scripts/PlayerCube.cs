using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class PlayerCube : MonoBehaviour
{
    [SerializeField] private TrackGroundSpawner _trackSpawner;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private UnityEvent GameOver;


    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out SpawnNextTrackTrigger next))
        {
            _audioSource.Play();
            _trackSpawner.SpawnTrack();
        }
    }


    public void Respawn()
    {
        GameOver?.Invoke();
    }

    public void PlayEffect()
    {
        _particleSystem.Play();
    }

    
}
