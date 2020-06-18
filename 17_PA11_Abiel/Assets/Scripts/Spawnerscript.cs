using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] prefabs;
    public int randomprefabs;
    public float spawnrate = 2f;
    float nextspawn = 0;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("prefabs", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {


        SpawnObjects();
    }

    void SpawnObjects()
    {
        if(Time.time > nextspawn)
        {
            nextspawn = Time.time + spawnrate;
            randomprefabs = Random.Range(0, 3);
            PositionY = Random.Range(4, -4f);
            this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
            Instantiate(prefabs[randomprefabs], transform.position, Quaternion.identity);
        }
        
       
    }
}
