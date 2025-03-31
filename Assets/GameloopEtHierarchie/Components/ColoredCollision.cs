using UnityEngine;

namespace GameLoopEtHierarchie.Components {
    public class ColoredCollision : MonoBehaviour {

        public Color CollisionColor = Color.red;
    
        private Color _baseColor;
    
        private void Awake() {
            _baseColor = GetComponent<MeshRenderer>().material.color;
        }

        private void OnTriggerEnter(Collider other) {
            GetComponent<MeshRenderer>().material.color = CollisionColor;
        }

        private void OnTriggerExit(Collider other) {
            GetComponent<MeshRenderer>().material.color = _baseColor;
        }

    }
}
