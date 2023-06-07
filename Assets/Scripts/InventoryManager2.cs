using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager2 : MonoBehaviour
{
   public static InventoryManager2 instance;

    //public ScriptableWeapon[] weapons;
    public ScriptableArmature[] armatures;
    //public Text[] weaponsNames;
    //public Image[] weaponsSprites;
    public Text[] armaturesNames;
    public Image[] armaturesSprites;
    public Text[] armaturesPrices;

    void Awake()
    {
        instance  = this;
    }

    /*public void AddWeapon(ScriptableWeapon weapon)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = weapon;
                weaponsNames[i].text = weapon.weaponName;
                weaponsSprites[i].sprite = weapon.weaponSprite;

                return;
            }
        }
    }*/
    public void AddArmature(ScriptableArmature armature)
    {
        for (int j = 0; j < armatures.Length; j++)
        {
            if(armatures[j] == null )
            {
                armatures[j] = armature;
                armaturesNames[j].text = armature.armatureName;
                armaturesSprites[j].sprite = armature.armatureSprite;
                armaturesPrices[j].text = armature.armaturePrice;

                return;
            }
        }
    }
}
