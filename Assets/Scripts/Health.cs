using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Slider HealthBar;

    public int DeafaultHP = 20;

    public double CurrentHP;
    public double CurrentHp
    {
        get { return CurrentHP; }
        set { CurrentHP = value; }
    }
    
    

    float HealthFloat = (float)CurrentHP;
    



    // Start is called before the first frame update
    void Start()
    {
        CurrentHP = DeafaultHP;
    }

    public void TakeDamage(double Damage)
    {
        CurrentHP -= Damage;
        HealthBar.value = CurrentHP;
        if(CurrentHP <= 0)
        {
            Destroy(gameObject);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealt()
    {
        if (CurrentHP > 0)
        {
            HealthBar.value = CurrentHP;
        }
        if (CurrentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}