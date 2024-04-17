using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetgame2 : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject game2manager;
    private float dificuilty;
    void Start()
    {
        game2manager = GameObject.Find("Game2 manager");
        dificuilty = game2manager.GetComponent<game2manager>().dificuilty;
        Destroy(gameObject,5/dificuilty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        game2manager.GetComponent<game2manager>().addscore();
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
