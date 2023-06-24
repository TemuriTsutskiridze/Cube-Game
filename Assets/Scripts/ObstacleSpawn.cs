using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle;

    float spawnTimer = 0f;
    public float spawnTime = 400f;
    private float spaceBetweenObstacleAndPlayer = 200;
    public float destroyRange = 50f;

    private void Update()
    {
        spawnTimer++;
        if(spawnTimer >= spawnTime)
        {
            Instantiate(obstacle, new Vector3(0, 1, player.transform.position.z + spaceBetweenObstacleAndPlayer), Quaternion.identity);
            spawnTimer = 0;
        }

        /*if(player.transform.position.z >= obstacle.transform.position.z + destroyRange)
        {
            Destroy(obstacle);
        }*/
    }
}
