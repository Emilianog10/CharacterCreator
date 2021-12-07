using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public SpriteRenderer ArmourRenderer;
    public SpriteRenderer WeaponRenderer;
    public void SetArmor(Sprite newSprite)
    {
        ArmourRenderer.sprite = newSprite;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }
}
