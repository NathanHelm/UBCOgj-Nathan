using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBarriers : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject g;
    private void OnDisable()
    {
        g.SetActive(true);
    }
}
