using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class firebullet : MonoBehaviour
{
    public GameObject bulletprefab;
    public Transform bulletspawn;
    public float firespeed = 20;
    AudioSource bulletsource;
    public AudioClip noise;
    public ParticleSystem particles;
    
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grab = GetComponent<XRGrabInteractable>();
        grab.activated.AddListener(shoot);
       bulletsource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shoot(ActivateEventArgs arg)
    {
        particles.Play();
        bulletsource.PlayOneShot(noise);
        GameObject bullet = Instantiate(bulletprefab);
        bullet.transform.position = bulletspawn.position;
        bullet.GetComponent<Rigidbody>().velocity = bulletspawn.forward * firespeed;
        Destroy(bullet, 5);
    }
    
}
