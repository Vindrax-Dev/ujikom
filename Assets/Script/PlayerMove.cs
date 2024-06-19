using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Script
{
    public class PlayerMove : MonoBehaviour
    {
        //MovementVariable
        public float moveSpeed=3;
        private CharacterController _controller;
        private float hInput;
        [HideInInspector] public Vector3 dir;
        //variable shoot
        //variable
        public GameObject bullet;
        public Transform shootPosition;
        // Start is called before the first frame update
        void Start()
        {
            _controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            getDirection();
            if (Input.GetButtonDown("Fire1"))
            {
                Tembak();
            }
        }
        void Tembak()
        {
            //summon
            Instantiate(bullet, shootPosition.position, shootPosition.rotation);
        }
        void getDirection()
        {
            hInput = Input.GetAxisRaw("Horizontal");
            dir = transform.right * hInput;
            _controller.Move(dir.normalized * moveSpeed * Time.deltaTime);
        }
        
    }
}
