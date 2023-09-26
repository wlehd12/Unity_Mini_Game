using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changedot : MonoBehaviour
{
    private PlayerLook script;
    private Image m_Image;
    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        script = GameObject.Find("Playercamera").GetComponent<PlayerLook>();
        if(script.changedot == true)
        {
            m_Image.color = new Color(1, 0, 0);
        }
        else if(script.changedot == false)
        {
            m_Image.color = new Color(0, 0, 1);
        }
    }
}
