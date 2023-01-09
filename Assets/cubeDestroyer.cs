using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDestroyer : MonoBehaviour
{
    
    [SerializeField] private GameObject prefab;
    [SerializeField] private float time;
    [SerializeField] private float distance;
    void Start()
    {
       StartCoroutine(spawnCube());
    }



    IEnumerator spawnCube(){

        while(true){

            float positionX = Random.Range(0, Screen.width);
            float positionY = Random.Range(0, Screen.height);

            Vector3 positionWorld = Camera.main.ScreenToWorldPoint(new Vector3(positionX,positionY,distance));
            Instantiate(prefab, positionWorld, Quaternion.identity );
            yield return new WaitForSeconds(time);
        
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
