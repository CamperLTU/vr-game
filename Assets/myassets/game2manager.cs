using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class game2manager : MonoBehaviour
{
    public float score;
    public GameObject scoreboard;
    public TMP_Text scorecounter;
    public TMP_Text dificuiltycounter;
    public float dificuilty;
    private bool stop;
    public float maxdificuilty;
    public GameObject targetdummy;
    public float numberofenemies = 10;
    public GameObject startbutton;
    private float current;
    private bool started;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        stop = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dificuilty < 1)
        {
            dificuilty = 1;
        }
        if (dificuilty > 7) 
        {
            dificuilty = 7;
        }
        if (started)
        {
            startbutton.GetComponent<Image>().color = Color.blue;
        }
        else
        {
            startbutton.GetComponent<Image>().color = Color.gray;
        }
        scorecounter.text = score.ToString();
        dificuiltycounter.text = dificuilty.ToString();
    }
    public void start()
    {
        if (!started) 
        {
            spawntargetdummy();
            started = true;
        }
        
    }

    private void spawntargetdummy()
    {
        
        stopgame();
        Resetcounter();
        current = 0;
        numberofenemies = (dificuilty * 2) + 10;
        StartCoroutine(waitforspawn(5/dificuilty));
        

    }

    public void stopgame()
    {
        stop = true;
        
        StopCoroutine(waitforspawn(5/dificuilty));
    }
    public void Resetcounter()
    {
        score = 0;
        stop = false;

    }
    public void addscore()
    {
        score++;
    }
    public void increasedificuilty()
    {
        dificuilty++;
    }
    public void decreasedificuilty()
    {
        dificuilty--;
    }
    private IEnumerator waitforspawn(float waittime)
    {

        
        current += 1;
        if (current < numberofenemies + 1 && !stop) 
        {
            Instantiate(targetdummy);
            targetdummy.transform.position = new Vector3(Random.Range(10, 20), 1, Random.Range(-2, 2));
            yield return new WaitForSeconds(5 / dificuilty);
            StartCoroutine(waitforspawn(5 / dificuilty));
        }
        else
        {
            started = false;
            current = 0;
        }

    }
}
