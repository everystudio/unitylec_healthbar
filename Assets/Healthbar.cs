using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    private Transform m_tfBar;

    private void Awake()
    {
        m_tfBar = transform.Find("bar");
    }

    public void SetSize(float _fNormalize)
    {
        m_tfBar.localScale = new Vector3(_fNormalize, 1.0f);
        GetComponent<Animator>().SetFloat("health_rate", _fNormalize);
    }
}
