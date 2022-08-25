using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;

    public int spawnAmount = 1000;
    List<GameObject> enemies;
    void Start()
    {
        enemies = new List<GameObject>();
        for(int i = 0; i <spawnAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(Enemy);
            obj.SetActive(true);
            enemies.Add(obj);
        }
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
