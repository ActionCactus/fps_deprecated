using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActionCactus.Controllers.StateMachines
{
    public class PlayerCharacter : MonoBehaviour
    {
        public float speed = 0.5f;
        private float testPos = 0f;
        private Rigidbody rb;

        // Use this for initialization
        void Start()
        {
            this.rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetKey("w"))
            {
                rb.transform.Translate(0, 0, this.speed);
                testPos += testPos + speed;
                rb.MovePosition(new Vector3(0, 0, testPos));
            }

            if (Input.GetKey("s"))
            {
                rb.transform.Translate(0, 0, -this.speed);
            }

            if (Input.GetKey("a"))
            {
                rb.transform.Translate(-this.speed, 0, 0);
            }

            if (Input.GetKey("d"))
            {
                rb.transform.Translate(this.speed, 0, 0);
            }
        }
    }
}