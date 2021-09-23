using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{

    public float life = 100;
    public Image lifeBar;
    
    void Update()
    {
        life = Mathf.Clamp(life, 0, 100);
        lifeBar.fillAmount = life / 100;
    }
}
