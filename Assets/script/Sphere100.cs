using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere100 : MonoBehaviour
{
        private Vector3 player_position;
        public float scale;
        // Start is called before the first frame update
        void Start()
        {
                this.transform.localScale = new Vector3(-scale, scale, scale);
        }

        // Update is called once per frame
        void Update()
        {
                player_position=Player.m_instance.transform.position;
                //this.transform.localPosition=player_position;
        }
}
