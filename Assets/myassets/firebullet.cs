using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class firebullet : MonoBehaviour
{
    public GameObject bulletprefab;
    public Transform bulletspawn;
    public float firespeed = 20;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grab = GetComponent<XRGrabInteractable>();
        grab.activated.AddListener(shoot);
        grab.activated.AddListener(getridoflight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shoot(ActivateEventArgs arg)
    {
        GameObject bullet = Instantiate(bulletprefab);
        bullet.transform.position = bulletspawn.position;
        bullet.GetComponent<Rigidbody>().velocity = bulletspawn.forward * firespeed;
        Destroy(bullet, 5);
    }
    public void getridoflight(ActivateEventArgs arg)
    {
        light.SetActive(false);
    }
}
