using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    public string unitGama;
    public int uLevel;

    public int damage;

    public int currentHealtH;
    public int MaxHP;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public bool tDamage(int Dmg)
    {
        currentHealtH -= Dmg;
        if (currentHealtH <= 0)
            return true;
        else
            return false;

    }


    public void healing(int ammount)
    {
        currentHealtH += ammount;
        if (currentHealtH > MaxHP)
            currentHealtH = MaxHP;


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("isHit", true);
        }
        else
        {
            anim.SetBool("isHit", false);
        }




    }
}
