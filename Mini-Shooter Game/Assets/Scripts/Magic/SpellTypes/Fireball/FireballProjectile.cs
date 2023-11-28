using UnityEngine;

namespace Magic.SpellTypes.Fireball
{
    public class FireballProjectile : MonoBehaviour
    {

        private float _timeAlive;
        public FireballSpell FireballSpell { private get; set; }
    
        // Update is called once per frame
        void Update()
        {
            _timeAlive += Time.deltaTime;
            if (_timeAlive >= 5)
            {
                Destroy(gameObject);
            }
        }
    }
}
