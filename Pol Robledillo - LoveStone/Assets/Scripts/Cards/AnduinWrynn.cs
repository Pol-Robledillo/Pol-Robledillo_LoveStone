using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnduinWrynn : Avatar
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.gameManager.AvatarName.text = AvatarSO.Name.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
