using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpown : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] bullets;
    int randomSpawnPoint, RandomBullets;
    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        //InvokeRepeating("SpawnBullets", 0f, 1f);
        StartCoroutine(SpawnBullet());
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void SpawnBullets()
    {
        /*if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            RandomBullets = Random.Range(0, bullets.Length);
            Instantiate(bullets[RandomBullets], spawnPoints[randomSpawnPoint].position, Quaternion.identity);

        }*/
    }
    public IEnumerator SpawnBullet()
    {

        int numberOfBullets = 0;

        while (numberOfBullets <= 5)
        {
            numberOfBullets++;
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            RandomBullets = Random.Range(0, bullets.Length);
            Instantiate(bullets[RandomBullets], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }

        Debug.Log("Exit spawn bullets");

    }
}
