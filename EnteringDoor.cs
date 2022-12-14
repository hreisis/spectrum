using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteringDoor : MonoBehaviour
{
    public GameObject AreaYelp;
    public GameObject AreaInfo;
    public GameObject AreaInsta;

    public GameObject objGate;
    public GameObject objYelp;
    public GameObject objInfo;
    public GameObject objInsta;
    void Start()
    {
        objGate.SetActive(true);
        objYelp.SetActive(false);
        objInfo.SetActive(false);
        objInsta.SetActive(false);
    }

    void OnCollisionEnter (Collision collision)
    {
        print(collision.collider.name);
    }

    void OnTriggerEnter (Collider collision)
    {
        if (collision.GetComponent<Collider>().name == "AreaYelp")
        {
            objGate.SetActive(false);
            objYelp.SetActive(true);
            objInfo.SetActive(false);
            objInsta.SetActive(false);
        }
        else if (collision.GetComponent<Collider>().name == "AreaInfo")
        {
            objGate.SetActive(false);
            objYelp.SetActive(false);
            objInfo.SetActive(true);
            objInsta.SetActive(false);
        }
        else if (collision.GetComponent<Collider>().name == "AreaInsta")
        {
            objGate.SetActive(false);
            objYelp.SetActive(false);
            objInfo.SetActive(false);
            objInsta.SetActive(true);
        }
        else
        {
            objGate.SetActive(true);
            objYelp.SetActive(false);
            objInfo.SetActive(false);
            objInsta.SetActive(false);
        }
    }

}
