using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Sequencer : MonoBehaviour {

    [SerializeField]
    private Scr_Conductor cond;

    public Button[] sequence;

    public GameObject proj;

    private void Awake()
    {
        //cond = FindObjectOfType<Scr_Conductor>().GetComponent<Scr_Conductor>();
    }
}
