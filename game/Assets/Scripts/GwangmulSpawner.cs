using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GwangmulSpawner : MonoBehaviour
{
    public Transform parent;
    public GameObject prefab;
    GameObject Gwangmulspawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "NPC")
        {           
            Debug.Log("detect and spawn");

            Gwangmulspawn = Instantiate(prefab);
            prefab.transform.position = parent.transform.position;
            Destroy(gameObject);
        }

    }
}