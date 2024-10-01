using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Image Char, Spell, Token, Power, Avatar;
    public Text CharMana, CharDesc, CharName, CharDMG, CharHP, SpellName, SpellMana, SpellDesc, PowerMana, TokenHP, TokenDMG, AvatarName;

    private void Awake()
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this)
        {
            Destroy(gameObject);
        }
        GameManager.gameManager = this;
    }
}