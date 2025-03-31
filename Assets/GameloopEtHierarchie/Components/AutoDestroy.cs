using UnityEngine;

namespace GameLoopEtHierarchie.Components {
    public class AutoDestroy : MonoBehaviour {

        public float TimeBeforeDestroy = 2f;
    
        private void Start() {
            Invoke(nameof(DestroyThis), TimeBeforeDestroy);
        }

        private void DestroyThis() {
            Destroy(gameObject);
        }

    }
}
