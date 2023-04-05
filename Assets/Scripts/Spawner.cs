using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;
    GameObject spawner;
    

    // Start is called before the first frame update
    void Start()
    { 
        spawner = GameObject.Find("Spawner");
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
          
            
            Instantiate(prefabToSpawn, spawner.transform.position, spawner.transform.rotation);
            
        }
    }
}
