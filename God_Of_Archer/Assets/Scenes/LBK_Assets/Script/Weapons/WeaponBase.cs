using UnityEngine;
using Fusion;

namespace GodOfArcher
{
    // Common weapon base class for all basic examples
    public class WeaponBase : NetworkBehaviour
    {
        // PUBLIC MEMBERS

        public Transform FireTransform => _fireTransform;

        // PRIVATE MEMBERS

        [SerializeField]
        private Transform _fireTransform;
        [SerializeField]
        private AudioClip _fireClip;
        [SerializeField]
        private Transform _fireSoundSourcesRoot;

        private AudioSource[] _fireSoundSources;

        public bool IsSwitching => _switchTimer.ExpiredOrNotRunning(Runner) == false;

        [Networked, HideInInspector]
        public Bow_Weapons CurrentWeapon { get; set; }
        [HideInInspector]
        public Bow_Weapons[] AllWeapons;

        [Networked]
        private TickTimer _switchTimer { get; set; }
        [Networked]
        private Bow_Weapons _pendingWeapon { get; set; }

        private Bow_Weapons _visibleWeapon;


        // PROTECTED METHODS

        protected void PlayFireEffect()
        {
            /*// In multipeer mode fire sounds are played only for visible runner
            if (Runner.GetVisible() == false)
                return;

            if (_fireSoundSources == null)
            {
                _fireSoundSources = _fireSoundSourcesRoot.GetComponentsInChildren<AudioSource>();
            }

            // Find free audio source and play fire sound
            for (int i = 0; i < _fireSoundSources.Length; i++)
            {
                var source = _fireSoundSources[i];

                if (source.isPlaying == true)
                    continue;

                source.clip = _fireClip;
                source.Play();
                return;
            }

            Debug.LogWarning("No free fire sound source", gameObject);*/
        }

        public void Draw(bool justPressed)
        {
            if (CurrentWeapon == null || IsSwitching)
                return;

            CurrentWeapon.Draw(FireTransform.position, FireTransform.forward, justPressed);
        }

        public void Shoot(bool justReleased)
        {
            if (CurrentWeapon == null || IsSwitching)
                return;

            CurrentWeapon.Shoot(FireTransform.position, FireTransform.forward, justReleased);
        }
        public void Reload()
        {
            if (CurrentWeapon == null || IsSwitching)
                return;

            CurrentWeapon.Reload();
        }

        public void Stop()
        {
            if (CurrentWeapon == null || IsSwitching)
                return;

            CurrentWeapon.Stop();
        }

        /*public void SwitchWeapon(EWeaponType weaponType)
        {
            var newWeapon = GetWeapon(weaponType);

            if (newWeapon == null || newWeapon.IsCollected == false)
                return;
            if (newWeapon == CurrentWeapon && _pendingWeapon == null)
                return;
            if (newWeapon == _pendingWeapon)
                return;

            if (CurrentWeapon.IsReloading)
                return;

            _pendingWeapon = newWeapon;
            _switchTimer = TickTimer.CreateFromSeconds(Runner, WeaponSwitchTime);

            // For local player start with switch animation but only
            // in forward tick as starting animation multiple times
            // during resimulations is not desired.
            if (HasInputAuthority && Runner.IsForward)
            {
                CurrentWeapon.Animator.SetTrigger("Hide");
                SwitchSound.Play();
            }
        }

        public bool PickupWeapon(EWeaponType weaponType)
        {
            if (CurrentWeapon.IsReloading)
                return false;

            var weapon = GetWeapon(weaponType);
            if (weapon == null)
                return false;

            if (weapon.IsCollected)
            {
                // If the weapon is already collected at least refill the ammo.
                weapon.AddAmmo(weapon.StartAmmo - weapon.RemainingAmmo);
            }
            else
            {
                // Weapon is already present inside Player prefab,
                // marking it as IsCollected is all that is needed.
                weapon.IsCollected = true;
            }

            SwitchWeapon(weaponType);

            return true;
        }

        public Weapon GetWeapon(EWeaponType weaponType)
        {
            for (int i = 0; i < AllWeapons.Length; ++i)
            {
                if (AllWeapons[i].Type == weaponType)
                    return AllWeapons[i];
            }

            return default;
        }*/

        public override void Spawned()
        {
            if (HasStateAuthority)
            {
                CurrentWeapon = AllWeapons[0];
                //CurrentWeapon.IsCollected = true;
            }
        }

        public override void FixedUpdateNetwork()
        {
            TryActivatePendingWeapon();
        }

        public override void Render()
        {
            if (_visibleWeapon == CurrentWeapon)
                return;

            int currentWeaponID = -1;

            // Update weapon visibility
            for (int i = 0; i < AllWeapons.Length; i++)
            {
                var weapon = AllWeapons[i];
                if (weapon == CurrentWeapon)
                {
                    currentWeaponID = i;
                    weapon.ToggleVisibility(true);
                }
                else
                {
                    weapon.ToggleVisibility(false);
                }
            }

            _visibleWeapon = CurrentWeapon;

            //Animator.SetFloat("WeaponID", currentWeaponID);
        }

        private void Awake()
        {
            // All weapons are already present inside Player prefab.
            // This is the simplest solution when only few weapons are available in the game.
            AllWeapons = GetComponentsInChildren<Bow_Weapons>();
        }

        private void TryActivatePendingWeapon()
        {
            if (IsSwitching == false || _pendingWeapon == null)
                return;

            /*if (_switchTimer.RemainingTime(Runner) > WeaponSwitchTime * 0.5f)
                return; // Too soon.*/

            CurrentWeapon = _pendingWeapon;
            _pendingWeapon = null;

            // Make the weapon immediately active.
            CurrentWeapon.gameObject.SetActive(true);

            if (HasInputAuthority && Runner.IsForward)
            {
                //CurrentWeapon.Animator.SetTrigger("Show");
            }
        }
    }
}
