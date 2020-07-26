using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordman : Character
{
    // Start is called before the first frame update
    void Start()
    {
        Atk = 10;
    }
    public void SuperAttack()
    {
        //Enemy Hp -= (Atk + BonusAtk)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
