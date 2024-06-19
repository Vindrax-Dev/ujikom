using System.Collections;
using UnityEngine;

namespace Script
{
    public class EnemySpawner : MonoBehaviour
    {
        //variable Enemy Spawner
        public GameObject enemyPrefab;
        public float enemySpeed = 5f;
        public int spawnCount = 5;
        public float interval = 2f;

        public float spawnRadius = 5f;
        // Start is called before the first frame update
        void Start()
        {
            //instantiate
            StartCoroutine(SpawnEnemy());
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        IEnumerator SpawnEnemy()
        {
            for (int i = 0; i < spawnCount; i++)
            {
                Vector3 randomSpawn = transform.position + Random.insideUnitSphere * spawnRadius;
                GameObject clone = Instantiate(enemyPrefab, randomSpawn, Quaternion.identity);
                //biar gerak 
                clone.GetComponent<Enemy>().speed = enemySpeed;
              
                yield return new WaitForSeconds(interval);
            }
        }
        
    }
}
