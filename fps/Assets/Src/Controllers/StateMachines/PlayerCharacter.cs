using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionCactus.Controllers.StateMachines
{
    public class PlayerCharacter : MonoBehaviour
    {
        private
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey("w"))
            {
                this.transform.Translate(0, 0, 1);
            }

            if (Input.GetKey("s"))
            {
                this.transform.Translate(0, 0, -1);
            }

            if (Input.GetKey("a"))
            {
                this.transform.Translate(-1, 0, 0);
            }

            if (Input.GetKey("d"))
            {
                this.transform.Translate(1, 0, 1);
            }
        }
    }
}