using Fusion;
using UnityEngine;

namespace GodOfArcher
{
    public enum BeaconState { Active, Inactive, Ignited, Extinguished }
    /// <summary>
    /// Periodically checks for an object with Health component within radius and refills health.
    /// </summary>
    public class Signal_Fire : NetworkBehaviour
	{
		public float      Heal = 50f;
		public float      Radius = 1f;
		public float      Cooldown = 30f;
		public LayerMask  LayerMask;
		public GameObject FireObject;
		public Gameplay gameplay;
        public BeaconState State { get; private set; } = BeaconState.Active;

        public bool CanIgnite => State == BeaconState.Active;
        public bool CanExtinguish => State == BeaconState.Ignited;

		public bool IsActive = false;
        public string beaconName;


		public override void FixedUpdateNetwork()
		{
			if (IsActive == false)
				return;
		}

        // ¡°»≠
        public void Ignite()
        {
            if (!CanIgnite) return;
            State = BeaconState.Ignited;
			IsActive = true;
			gameplay.SetRemainingTime(40.0f, beaconName);
            Debug.Log($"{beaconName} ∫¿»≠ ¡°»≠µ (Ignited)!");
        }

        // º“»≠
        public void Extinguish()
        {
            if (!CanExtinguish) return;
            State = BeaconState.Extinguished;
            IsActive = false;
			gameplay.Fire_Extinguished();
            Debug.Log($"{beaconName} ∫¿»≠ º“»≠µ (Extinguished)!");
        }

        // ¥Ÿ∏• ∫¿»≠∞° ¡°»≠µ∆¿ª ∂ß ∫Ò»∞º∫»≠
        public void SetInactive()
        {
            State = BeaconState.Inactive;
			gameObject.SetActive( false );
            Debug.Log($"{beaconName} ∫¿»≠ ∫Ò»∞º∫»≠(Inactive)");
        }

		public void SetActive()
		{
			State = BeaconState.Active;
            IsActive = false;
            gameObject.SetActive(true);
		}

        public override void Render()
		{
			FireObject.SetActive(IsActive);
		}

		private void OnDrawGizmos()
		{
			Gizmos.DrawWireSphere(transform.position + Vector3.up, Radius);
		}
	}
}
