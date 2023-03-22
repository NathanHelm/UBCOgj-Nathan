using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInteractable : MonoBehaviour
{
    bool isSpawn = true;
    [SerializeField]
    int time = 10;
    public
    GameObject prefabG;
    [SerializeField] float x, y;

    public List<GameObject> gameObjects;


    private void OnEnable()
    {
       
    }
    public IEnumerator Spawn(GameObject g)
    {
        isSpawn = false;
        //spawn every minute
        yield return new WaitForSeconds(time);
        //spawns ghos
        GameObject singleG = Instantiate(g, new Vector3(x,y,0),Quaternion.identity);
        gameObjects.Add(singleG);



        isSpawn = true;
        yield return null;
    }
    private void Update()
    {
        if (isSpawn == true)
        {
            StartCoroutine(Spawn(prefabG));
        }
        

    }
   
        
    
    
}
