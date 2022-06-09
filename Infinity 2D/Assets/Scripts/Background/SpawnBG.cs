using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBG : MonoBehaviour
{
    public List<GameObject> bgList = new List<GameObject>();
    public float timeSpawn;

    private float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;

        //if (timeCount >= timeSpawn)
        //{
        //    Instantiate();
        //}
    }
}
