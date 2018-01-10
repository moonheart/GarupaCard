using GarupaCard.Shared.Models;

namespace GarupaCard.Shared.Utils
{
    public static class Extentions
    {
        public static string GetCardThumbTrained(this Card card)
        {
            return $"https://bangdream.ga/assets/thumb/chara/card00000_{card.cardRes}_after_training.png";
        }
    }
}
