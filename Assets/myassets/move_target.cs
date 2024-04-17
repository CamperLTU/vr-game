using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_target : MonoBehaviour
{
    // Start is called before the first frame update
    public float currentdistance;
    public Transform [] locations;

    void Start()
    {
        currentdistance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentdistance == 0)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, locations[0].position, 0.01f);
        }
        else if (currentdistance == 1) 
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position,locations[1].position,0.01f);
        }
        else if (currentdistance == 2)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, locations[2].position, 0.01f);
        }

    }
    public void moveup()
    {
        if(currentdistance == 0)
        {
            return;
        }
        currentdistance -= 1;
    }
    public void movedown() 
    {
        if (currentdistance == 2)
        {
            return;
        }
        currentdistance += 1;
    }
}
