using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pinchos", menuName = "GameItems/Enemies/Pinchos", order = 0)]
public class SOPinchos : ScriptableObject
{
    public int damage = 1;
    public Vector3 size = new Vector3(6, 6, 6);
    public string nombre = "pinchos";
}
