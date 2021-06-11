using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Planetas;
    private float limitUp = 12f;
    private float limitDown = -4;
    private float SpawnX = 12;
    private float startDelay = 1.0f;
    private float SpawnInterval = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnPlanetas", startDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnPlanetas()
    {
        Vector3 SpawnPos = new Vector3(SpawnX, Random.Range(limitUp, limitDown), 0);
        Instantiate(Planetas[Random.Range(0, 3)], SpawnPos, Planetas[Random.Range(0, 3)].transform.rotation);
    }
}
