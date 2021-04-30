using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    /*[Header("ChallengeObj Game Object")]
    public GameObject challengeObject*/
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 1f;
    [Header("Default Spawn Time")]
    public float spawnTime = 2f;
    void Start()
    {
        //InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(15, -2.75f, 0);
    }
    /*void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }*/
}
