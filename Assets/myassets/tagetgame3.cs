using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetgame3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gamemanager;
    private float dificuilty;
    void Start()
    {
        gamemanager = GameObject.Find("Game3 manager");
        dificuilty = gamemanager.GetComponent<game3manager>().dificuilty;
        Destroy(gameObject, 5/dificuilty);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        gamemanager.GetComponent<game3manager>().addscore();
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
