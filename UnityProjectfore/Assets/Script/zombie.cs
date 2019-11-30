using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public float hp;

    public float Attack;

    public AudioSource ZOM;

    public AudioClip ZOMTWO;

    public player playNOW;

    int deadtime;

    　




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)&&hp>0) 
        {
            Attacker();
        }

        if (hp<=0&& deadtime<1)
        {
            Dead();
        }
    }
    public void Attacker()
    {
        ZOM.PlayOneShot(ZOMTWO);

        if (playNOW.hp <= 0)
        {
            return;
        }
        playNOW.hp -= (Random.Range(0f, 10f));

        if (playNOW.hp > 0)
        {
            Debug.Log("僵屍剩餘血量" + playNOW.hp);
        }

        else
        {
            Debug.Log("僵屍剩餘血量" + 0);
        }
    }
    public void Dead() 
    {
        Debug.Log("我死了");
        deadtime = 1;
    }
}
