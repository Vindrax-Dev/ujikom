using UnityEngine;

namespace Script
{
    public class Enemy : MonoBehaviour
    {
        //variable enemy
        public int health = 100;
        public float speed =10;
        public void KeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
            //Enemy akan bergerak saat di intantiate
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
