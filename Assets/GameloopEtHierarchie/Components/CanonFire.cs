using UnityEngine;

namespace GameLoopEtHierarchie.Components {
    public class CanonFire : MonoBehaviour {

        public GameObject AmmoPrefab;
        public int FirePower;

        public void Fire() {
            GameObject ammoShot = Instantiate(AmmoPrefab, transform.position, Quaternion.identity);
            ammoShot.GetComponent<Rigidbody>().AddForce(-transform.right * FirePower, ForceMode.VelocityChange);
        }

    }
}
