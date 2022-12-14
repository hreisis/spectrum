using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMushroom : MonoBehaviour
{
    public GameObject PrefAllMushrooms;
    GameObject AllMushrooms;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < PrefAllMushrooms.transform.childcount;)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
