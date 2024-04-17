using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class game3manager : MonoBehaviour
{
    public float score;
    public GameObject scoreboard;
    public TMP_Text scorecounter;

    public float dificuilty;
    private bool stop;
    public float maxdificuilty;
    public GameObject targetdummy;
    public float numberofenemies = 10;

    private float current;

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
        scorecounter.text = score.ToString();
    }
    public void start()
    {
        spawntargetdummy();
    }

    private void spawntargetdummy()
    {
        Resetcounter();
        stopgame();
        current = 0;
        numberofenemies = dificuilty * 2;
        StartCoroutine(waitforspawn(5 / dificuilty));


    }

    public void stopgame()
    {
        stop = true;

        StopCoroutine(waitforspawn(5 / dificuilty));
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

        yield return new WaitForSeconds(5 / dificuilty);
        current += 1;
        if (current < numberofenemies + 1)
        {
            Instantiate(targetdummy);
            targetdummy.transform.position = new Vector3(Random.Range(10, 20), Random.Range(0, 5), Random.Range(-3, -7));
            StartCoroutine(waitforspawn(5 / dificuilty));
        }
    }
}
