using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteringDoor : MonoBehaviour
{
    public GameObject Door1;
    Vector3 posDoor1;
    float disDoor1;
    // Start is called before the first frame update
    void Start()
    {
        posDoor1 = Door1.transform.position;
        disDoor1 = posDoor1.DistanceTo(this.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        disDoor1 = posDoor1.DistanceTo(this.transform.position);
        if (disDoor1 < 2f) {
            SceneManager.LoadScene(1);
        }
    }
}
