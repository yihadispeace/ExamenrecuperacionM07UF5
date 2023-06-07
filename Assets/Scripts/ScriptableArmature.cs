using UnityEngine;

[CreateAssetMenu(fileName = "New armature", menuName = "Items/New Arnmature")]
public class ScriptableArmature : ScriptableObject
{
    public string armatureName;
    public string armaureDescription;
    public Sprite armatureSprite;
    public float armatureResistence;
    public float armatureMagicResistance;
    public string armaturePrice;
}
