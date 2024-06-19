using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Script
{
    public class bullet : MonoBehaviour
    {
        //variable 
        public float speed = 300;
        public int damage = 25;
        
        
        // Start is called before the first frame update
        void Start()
        {
            //peluru akan bergerak saat di intantiate
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed;
        }

        // Update is called once per frame
        void Update()
        {
            //Destroy bullet
            Destroy(gameObject,3f);
        }

        private void OnCollisionEnter(Collision other)
        {
            Debug.Log("kena");
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.KeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}
