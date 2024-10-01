using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : Fighter
{
    public int Position;
    public CharacterSO Character;

    // Start is called before the first frame update
    public void SetToken()
    {
        CurrentDamage = Character.Damage;
        CurrentHP = Character.HP;
        GameManager.gameManager.Token.sprite = Character.Design;
        GameManager.gameManager.TokenHP.text = CurrentHP.ToString();
        GameManager.gameManager.TokenDMG.text = CurrentDamage.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
