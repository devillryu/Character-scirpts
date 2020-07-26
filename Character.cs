using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int HP; //HP ไม่ควรเป็น Public จึงเปลี่ยนเป็น Private
    public int hp
    {   
        get => HP;
        set
        {
            int HPtemp = HP;
            HP -= value;
            if(HP <= 0)
            {
                HP = 0;
                Status = "Dead";
                Dead();
            }
            else
            {
                HP = HPtemp;
                Status = "Alive";
            }
        }
    }
    private int Exp; //Same as HP
    public int exp
    {
        get => Exp;
        set
        {
            int Exptemp = Exp;
            Exp += value;
            if(Exp >= 100) //ควรเพิ่มตัวแปรกำหนด Level อีกที
            {
                Exp = 0;
                Level++;
                print("LEVEL UP!!");
            }
            else
            {
                Exp = Exptemp;
            }
        }
    }
    public int Atk {get; protected set;} = 10;
    public int Level {get; private set;} = 1;
    public string Status {get; private set;} = "Alive";

    public void Walk()
    {

    }
    public void Sit()
    {

    }
    public void Attack()
    {

    }
    public void Dead()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
