using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private Healthbar m_healthbar;
    private float m_fHealth;

    void Start()
    {
        m_fHealth = 1.0f;
        InvokeRepeating("DecreaseHealth", 0.0f, 0.1f);
    }
    private void DecreaseHealth()
    {
        m_fHealth -= 0.01f;
        if( m_fHealth < 0.0f)
        {
            m_fHealth = 0.0f;
        }
        m_healthbar.SetSize(m_fHealth);
    }



}
