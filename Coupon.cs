using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPaper : MonoBehaviour
{
    public GameObject PrefPapers;
    public Text myCouponText;

    List<GameObject> AllPapers = new List<GameObject>();

 
    float fCheckDist = 0.4f;

    public int intCoupon = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        myCouponText.text = "current Coupon count: " + intCoupon.ToString();


        for (int i = 0; i < PrefAllPapers.transform.childCount; i++)
        {
            AllPapers.Add(PrefAllPapers.transform.GetChild(i).gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject objPaper in AllPapers)
        {
            Vector3 myPos = this.transform.position;
            myPos.y = 0f;
            Vector3 paperPos = objPaper.transform.position;
            paperPos.y = 0f;

            float dist = Vector3.Distance(myPos, paperPos);

            if (dist < fCheckDist)
            {
                //print(dist.ToString());
                AllPapers.Remove(objPaper);
                Destroy(objPaper);
                intCoupon++;
                //print(intCoupon.ToString());

                myCouponText.text = "current Coupon count:" + intCoupon.ToString();
                break;
            }
        }

    }
}
