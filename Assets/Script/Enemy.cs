using UnityEngine;

namespace Script
{
    public class Enemy : MonoBehaviour
    {
        //variable enemy
        public int health = 100;

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
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
