using UnityEngine;

public class PickupCollisionTrigger : MonoBehaviour
{
    [SerializeField] private CubeStacker _cubeStacker;
    [SerializeField] private CollectTextSpawner _textSpawner;

    private Vector3 _direction = Vector3.back;
    private bool _isStacked = false;

    private void Start()
    {
        _cubeStacker = FindObjectOfType<CubeStacker>();
        _textSpawner = FindObjectOfType<CollectTextSpawner>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out PlayerCube playerCube) ||
            collision.collider.TryGetComponent(out PickupCube cube))
        {
            if (_isStacked == false)
            {
                _isStacked = !_isStacked;
                _textSpawner.SpawnText();
                _cubeStacker.IncreaseCube(gameObject);

                SetDirection();
            }
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ObstacleWall wall))
        {
            _cubeStacker.DecreaseCube(gameObject);

            SetDirection();
        }
    }


    private void SetDirection()
    {
        _direction = Vector3.forward;
    }


}
