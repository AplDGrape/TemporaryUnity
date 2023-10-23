using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    public Transform SamplePrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(3);
        Instantiate(SamplePrefab, transform.position, transform.rotation);
        StartCoroutine(SpawnEnemy());
        //this.SpawnBatchAtLoc(1);
        //this.StartCoroutine(this.TriggerEvery(Random.Range(0.2f, 0.5f)));
    }

    //WaitForSeconds wait = new WaitForSeconds(spawnInterval);
    //    while (currentNumberOfEnemies<maxNumberOfEnemies)
    //    {
    //        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
    //        Vector3 spawnPos = new Vector3(Random.Range(0, spawnPoints.Length), 1);

    //        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    //        currentNumberOfEnemies++;
    //                yield return wait;
    //    }
    //https://discussions.unity.com/t/how-to-spawn-enemies-on-my-spawnpoints/232363
    //https://www.youtube.com/watch?v=eQnhsWmKWRA

    //https://www.youtube.com/watch?v=f473C43s8nE
}
