using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GodOfArcher
{
<<<<<<< HEAD
    public class UIHPMP : MonoBehaviour
    {
        //[SerializeField] private PlayerStatus status;
        [SerializeField] private TextMeshProUGUI HPText;
        [SerializeField] private TextMeshProUGUI SPText;
        [SerializeField] private Slider HPSlider;
        [SerializeField] private Slider SPSlider;

        public void UpdateStatus(Player player)
        {
            if (HPSlider != null) HPSlider.value = Utils.Par(player.Health.CurrentHealth, player.Health.MaxHealth);
            if (HPText != null) HPText.text = $"{player.Health.CurrentHealth:F0} / {player.Health.MaxHealth:F0}";

            if (SPSlider != null) SPSlider.value = Utils.Par(player.Status.currentStamina, player.Status.MaxStamina);
            if (SPText != null) SPText.text = $"{player.Status.currentStamina:F0} / {player.Status.MaxStamina:F0}";
        }
}
=======
    [SerializeField] private PlayerStatus status;
    [SerializeField] private ShootBow Shoot;
    [SerializeField] private TextMeshProUGUI HPText;
    [SerializeField] private TextMeshProUGUI SPText;
    [SerializeField] private TextMeshProUGUI ArrowCount;
    [SerializeField] private Slider HPSlider;
    [SerializeField] private Slider SPSlider;

    private int AC;

    private void Start()
    {
        if (Shoot != null)
            AC = Shoot.arrowsRemaining;
    }

    private void Update()
    {
        if (HPSlider != null)
            HPSlider.value = Utils.Par(status.CurrentHp, status.maxHp);
        if (HPText != null)
            HPText.text = $"{status.CurrentHp:F0} / {status.maxHp:F0}";

        if (SPSlider != null)
            SPSlider.value = Utils.Par(status.CurrentStamina, status.MaxStamina);
        if (SPText != null)
            SPText.text = $"{status.CurrentStamina:F0} / {status.MaxStamina:F0}";

        if (Shoot != null)
            ArrowCount.text = $"{Shoot.arrowsRemaining:F0} / {AC:F0}";
    }
>>>>>>> LocalProto
}
