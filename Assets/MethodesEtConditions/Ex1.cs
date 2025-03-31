using UnityEngine;

namespace MethodesEtConditions
{
    public class Ex1 : MonoBehaviour
    {
        private void Update()
        {
            // Ici je lance la méthode SomeUseless Method
            SomeUselessMethod();
        }

        void SomeUselessMethod()
        {
            // Ici j'affiche i'm useless
            Debug.Log("I'm useless");
        }
        
    }
}
