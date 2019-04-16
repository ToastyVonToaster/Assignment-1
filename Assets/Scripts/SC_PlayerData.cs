using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData")]
public class SC_PlayerData : ScriptableObject
{
    [SerializeField]
    private string name;
    [SerializeField]
    private string description;
    [SerializeField]
    private int cost;
    [SerializeField]
    private int cooldown;
    [SerializeField]
    private GameObject particles;

    #region Get Data
    public string Description
    {
        get { return description; }
    }

    public string SpellName
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }

    public int Cooldown
    {
        get { return cooldown; }
    }

    public GameObject Effect
    {
        get { return particles; }
    }
    #endregion Get Data
}
