using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCard : ACard
{
    public EntitySO Entity;

    public void Invoke(Token token)
    {
        GameManager.gameManager.SpellMana.text = Mana.ToString();
        GameManager.gameManager.SpellDesc.text = Entity.Description;
        GameManager.gameManager.SpellName.text = Entity.Name;
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
