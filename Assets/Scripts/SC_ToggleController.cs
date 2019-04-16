using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_ToggleController : MonoBehaviour
{
    public Toggle poisonToggle;
    public Toggle bloodMistToggle;
    public Toggle soulSiphonToggle;
    public Toggle drainEssenceToggle;
    public Toggle hellToggle;
    public Toggle freezeToggle;

    public GameObject poisonPowder;
    public GameObject bloodMist;
    public GameObject soulSiphon;
    public GameObject drainEssence;
    public GameObject hellBreath;
    public GameObject soulFreeze;

    private void Start()
    {
        poisonToggle.isOn = false;
        bloodMistToggle.isOn = false;
        soulSiphonToggle.isOn = false;
        drainEssenceToggle.isOn = false;
        hellToggle.isOn = false;
        freezeToggle.isOn = false;

        poisonPowder.SetActive(false);
        bloodMist.SetActive(false);
        soulSiphon.SetActive(false);
        drainEssence.SetActive(false);
        hellBreath.SetActive(false);
        soulFreeze.SetActive(false);


    }

    private void FixedUpdate()
    {
        if (poisonToggle.isOn == true)
            poisonPowder.SetActive(true);
        else if (poisonToggle.isOn == false)
            poisonPowder.SetActive(false);

        if (bloodMistToggle.isOn == true)
            bloodMist.SetActive(true);
        else if (bloodMistToggle.isOn == false)
            bloodMist.SetActive(false);

        if (soulSiphonToggle.isOn == true)
            soulSiphon.SetActive(true);
        else if (soulSiphonToggle.isOn == false)
            soulSiphon.SetActive(false);

        if (drainEssenceToggle.isOn == true)
            drainEssence.SetActive(true);
        else if (drainEssenceToggle.isOn == false)
            drainEssence.SetActive(false);

        if (hellToggle.isOn == true)
            hellBreath.SetActive(true);
        else if (hellToggle.isOn == false)
            hellBreath.SetActive(false);

        if (freezeToggle.isOn == true)
            soulFreeze.SetActive(true);
        else if (freezeToggle.isOn == false)
            soulFreeze.SetActive(false);
    }
}
