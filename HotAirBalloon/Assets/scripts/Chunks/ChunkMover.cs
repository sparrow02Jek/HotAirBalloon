using UnityEngine;

namespace Chunks
{
    public class ChunkMover : MonoBehaviour
    {
        // Потом будем изменять это значение для ускорения
        [SerializeField] private float _moveSpeed;

        void FixedUpdate()
        {
            transform.Translate(Vector2.down * _moveSpeed * Time.fixedDeltaTime);
        }
    }
}
