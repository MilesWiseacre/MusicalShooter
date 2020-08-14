using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Conductor : MonoBehaviour {

    //BPM of current level
    public float _bpm;
    //The 16 steps in the 4x4 sequencer
    [HideInInspector]
    public float _seqSteps = 15, _curStep = 0;
    //The "fire rate", or beats per second
    public float fireRate
    {
        get { return (((60000 / _bpm) * .001f) / 4); }
        set { fireRate = value; }
    }
    //The time, added on to current time, until the next beat
    [HideInInspector]
    public float nextBeat = 0.0f;
    //Counting enemies on screen
    //public int _numEnemies;
    //[SerializeField]
    //int _maxEnemies;
    //Spawning enemies off screen
    Vector3[] spawnPoints;

    void FixedUpdate()
    {
        if (Time.time >= nextBeat)
        {
            StepForward();
            //if (_curStep == 0 && _numEnemies < _maxEnemies)
            //{
                //SpawnEnemy();
            //}
            //else
            //{

            //}
        }
    }

    void StepForward()
    {
        if (_curStep < _seqSteps)
        {
            _curStep++;
        }
        else
        {
            _curStep = 0;
        }
        nextBeat = Time.time + fireRate;
    }

    void SpawnEnemy()
    {
        //Instantiate(enemy, (player.transform.position + spawnPoint), Quaternion.identity);
        //_numEnemies++;
    }
}
