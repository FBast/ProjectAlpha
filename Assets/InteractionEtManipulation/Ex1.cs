using UnityEngine;

namespace InteractionEtManipulation
{
    public class Ex1 : MonoBehaviour
    {
        public float Speed;
    
        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Debug.Log(Time.deltaTime);
            transform.Translate(horizontal * Time.deltaTime * Speed, 0, vertical * Time.deltaTime * Speed);
        }
    }
}
