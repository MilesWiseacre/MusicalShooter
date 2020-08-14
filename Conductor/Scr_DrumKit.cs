using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_DrumKit : MonoBehaviour {

    [SerializeField]
    private Scr_Conductor cond;
    [SerializeField]
    private Scr_Sequencer Seq1;
    [SerializeField]
    private Scr_Sequencer Seq2;
    [SerializeField]
    private Scr_Sequencer Seq3;
    [SerializeField]
    private Scr_Sequencer Seq4;

    private Vector3 bullSpawn = new Vector2(0, 1.5f);

    private void Awake()
    {
        //cond = FindObjectOfType<Scr_Conductor>().GetComponent<Scr_Conductor>();
    }

    private void FixedUpdate()
    {
        if (Time.time >= cond.nextBeat)
        {
            if (Seq1.sequence[Mathf.RoundToInt(cond._curStep)].GetComponent<Scr_SeqButton>().active)
            {
                Debug.Log("Firing " + Seq1.proj.transform.name);
                Instantiate(Seq1.proj, transform.position + bullSpawn, transform.rotation);
            }
            if (Seq2.sequence[Mathf.RoundToInt(cond._curStep)].GetComponent<Scr_SeqButton>().active)
            {
                Debug.Log("Firing " + Seq2.proj.transform.name);
                Instantiate(Seq2.proj, transform.position + bullSpawn, transform.rotation);
            }
            if (Seq3.sequence[Mathf.RoundToInt(cond._curStep)].GetComponent<Scr_SeqButton>().active)
            {
                Instantiate(Seq3.proj, transform.position, transform.rotation, gameObject.transform);
            }
            if (Seq4.sequence[Mathf.RoundToInt(cond._curStep)].GetComponent<Scr_SeqButton>().active)
            {
                Instantiate(Seq4.proj, transform.position, transform.rotation);
            }
        }
    }
}
