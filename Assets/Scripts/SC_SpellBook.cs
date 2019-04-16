using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_SpellBook : MonoBehaviour
{
    
    public SC_PlayerData spells;

    public Text spellNameTxt;
    public Text descTxt;
    public Text spellCostTxt;
    public Text cooldownTxt;
    public GameObject effectObj;


    void Start()
    {
        descTxt.text = spells.Description;
        spellNameTxt.text = spells.SpellName;
        spellCostTxt.text = spells.Cost.ToString();
        cooldownTxt.text = spells.Cooldown.ToString();
        effectObj = spells.Effect;
    }

    private void Update()
    {
        descTxt.text = spells.Description;
        spellNameTxt.text = spells.SpellName;
        spellCostTxt.text = spells.Cost.ToString();
        cooldownTxt.text = spells.Cooldown.ToString();
        effectObj = spells.Effect;
    }


}
