using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : AInvocable
{
    public EntitySO Entity;
    public void HeroPower()
    {
        GameManager.gameManager.SpellMana.text = Mana.ToString();
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
