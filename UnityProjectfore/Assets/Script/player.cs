using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float hp;

    public float Attack;

    public AudioSource MU;

    public AudioClip playerMU;

    public zombie zombieNOW;

    int deadtime;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && hp > 0)
        {
            Attacker();
        }
        if (hp <= 0 && deadtime < 1)
        {
            Dead();
        }
    }
    public void Attacker()
    {
        MU.PlayOneShot(playerMU);

        if (zombieNOW.hp <= 0)
        {
            if (zombieNOW.hp <= 0)
            {
                return;
            }
            zombieNOW.hp -= (Random.Range(0f, 10f));

            if (zombieNOW.hp > 0)
            {
                Debug.Log("僵屍剩餘血量" + zombieNOW.hp);
            }

            else
            {
                Debug.Log("僵屍剩餘血量" + 0);
            }
        }

    }
    public void Dead()
    {
        Debug.Log("我死了");
        deadtime = 1;
    }


}
