using System.Collections.Generic;
using UnityEngine;

namespace Chunks
{
    public class ChunkPlacer : MonoBehaviour
    {
        // Масив чанков шаблонов для спавна
        [SerializeField] private Chunk[] _chunks;
        [SerializeField] private Chunk _firstChunkPrefab;

        // Максимальное значение кординаты и после которой чанк уничтожаеться
        [SerializeField] private float MAX_Y_POS = 14;
        [SerializeField] private int MAX_CHUNKS_COUNT = 5;

        // Заспавниные чанки
        private List<Chunk> _spawnedChunks;

        // Лямбда для получения последнего заспавнинего чанка
        private Chunk _lastChunk => _spawnedChunks[_spawnedChunks.Count - 1];

        // Лямбда для получения первого заспавнинего чанка
        private Chunk _firstChunk => _spawnedChunks[0];


        private void Start()
        {
            _spawnedChunks = new List<Chunk>();
            // Добавляем первый чанк в список чтобы не возникало проблем
            _spawnedChunks.Add(_firstChunkPrefab);

            // Спавним рандомный чанк
            SpawnChunk(GetRandomChunk());
        }


        private void Update()
        {
            // Позиция первого чанка меньше спавним новый чанк
            if (_firstChunk.Begin.position.y <= MAX_Y_POS)
                SpawnChunk(GetRandomChunk());

            // Если количество заспавненых чанков больше максимального значения удаляем первый чанк
            if (_spawnedChunks.Count > MAX_CHUNKS_COUNT)
                DestroyFirstChunk();
        }

        private void SpawnChunk(Chunk chunk)
        {
            // Выщитиваем позицыю чанка
            Vector3 chunkPosition = _lastChunk.End.position - chunk.Begin.localPosition;
            // Спавним
            Chunk newChunk = Instantiate(chunk, chunkPosition, Quaternion.identity, transform);

            // Добавляем
            _spawnedChunks.Add(newChunk);
        }

        private void DestroyFirstChunk()
        {
            // Дестроит чанк и удаляет его из списка
            Destroy(_firstChunk.gameObject);
            _spawnedChunks.Remove(_firstChunk);
        }

        private Chunk GetRandomChunk()
        {
            // Получаем рандомный чанк
            return _chunks[Random.Range(0, _chunks.Length)];
        }
    }
}
