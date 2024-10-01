using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCard : ACard
{
    public CharacterSO Character;
    
    public void Invoke(Token token)
    {
        GameManager.gameManager.CharMana.text = Mana.ToString();
        GameManager.gameManager.CharDesc.text = Character.Description;
        GameManager.gameManager.CharName.text = Character.Name;
        GameManager.gameManager.CharDMG.text = Character.Damage.ToString();
        GameManager.gameManager.CharHP.text = Character.HP.ToString();
        GameManager.gameManager.Char.sprite = Character.Design;
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
