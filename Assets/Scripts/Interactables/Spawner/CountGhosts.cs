using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountGhosts : MonoBehaviour
{

    public
    List<GameObject> allGhosts;
    [SerializeField]
    SpawnInteractable[] s;
    private void OnEnable()
    {
       
    }
    public void Gather()
    {
        
        foreach (SpawnInteractable ss in s)
        {
            foreach (GameObject sss in ss.gameObjects)
            {
                if (allGhosts.Count < ss.gameObjects.Count)
                {
                    allGhosts.Add(sss);
                    
                }
                
            }
        }
    }
}
