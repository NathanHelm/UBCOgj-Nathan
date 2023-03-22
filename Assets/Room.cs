using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Room : MonoBehaviour
{
    private Rigidbody2D prb;
    [SerializeField]
    GameObject room;
    [SerializeField]
    Image image;
    GameObject g;
    CountGhosts countGhosts;
    
    private void OnEnable()
    {
        prb = FindObjectOfType<PlayerMovement>().GetComponent<Rigidbody2D>();
        countGhosts = FindObjectOfType<CountGhosts>();
        image = GetComponent<Image>();
        g = GameObject.Find("Paused");
        Time.timeScale = 0;
        
       
    }
    public void Click()
    {
        Debug.Log("Click");
        Time.timeScale = 1;
       
        image.color = new Color(0,0,0);
        Destroy(room);
       
        PlayerHealth.Instance.health = 30;
        float cG = countGhosts.allGhosts.Count;
        countGhosts.Gather();
        for(int i = 1; i < countGhosts.allGhosts.Count*0.75; i++)
        {
            countGhosts.allGhosts.Remove(countGhosts.allGhosts[countGhosts.allGhosts.Count - 1]);
            Destroy(countGhosts.allGhosts[countGhosts.allGhosts.Count - i]);
            
           
           Debug.Log(countGhosts.allGhosts.Count / 2);


        }
        ResetCharacter();
        g.SetActive(false);

    }
    private void ResetCharacter()
    {
        prb.position = new Vector2(0.15f, 2.4f);
        
    }



}
