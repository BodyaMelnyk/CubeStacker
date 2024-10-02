using UnityEngine;
using UnityEngine.Events;

public class ObstacleWall : MonoBehaviour
{
    private TrailMover _trailMover;
    private RagdollController _ragdollControl;
    private PlayerMovement _mover;


    private void Start()
    {
        _ragdollControl = FindObjectOfType<RagdollController>();
        _trailMover = FindObjectOfType<TrailMover>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerMovement playerMover) && other.TryGetComponent(out PlayerCube player))
        {
            playerMover.Stop();
            _ragdollControl.EnableRagdoll();
            player.Respawn();
            _trailMover.Stop();
        }
    }

   
}
