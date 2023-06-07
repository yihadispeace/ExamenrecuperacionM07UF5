using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableWeapon[] weapons;
    //public ScriptableArmature[] armatures;
    public Text[] weaponsNames;
    public Image[] weaponsSprites;
    public Text[] weaponsPrices;
    //public Text[] armaturesNames;
    //public Image[] armaturesSprites;

    void Awake()
    {
        instance  = this;
    }

    public void AddWeapon(ScriptableWeapon weapon)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = weapon;
                weaponsNames[i].text = weapon.weaponName;
                weaponsSprites[i].sprite = weapon.weaponSprite;
                weaponsPrices[i].text = weapon.weaponPrice;

                return;
            }
        }
    }
    /*public void AddArmature(ScriptableArmature armature)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null )
            {
                weapons[i] = armature;
                weaponsNames[i].text = armature.armatureName;
                weaponsSprites[i].sprite = armature.armatureSprite;

                return;
            }
        }
    }*/

}
