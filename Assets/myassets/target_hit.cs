using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_hit : MonoBehaviour
{
    private Transform position;
    public GameObject hitparticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject hitmarker = Instantiate(hitparticle);
        hitmarker.transform.position = collision.transform.position;
        Destroy(hitmarker,10f);

    }
}
