using System;
using static System.Net.Mime.MediaTypeNames;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The rarest are number Legendary
            DemonsHunt demonshunt = new DemonsHunt("Legendary", 1200);
            BadIntentions badintentions = new BadIntentions("Epic", 400);
            YoungBlood youngblood = new YoungBlood("Rare", 30);
            Сatalog_of_skins<Skin> skin = new Сatalog_of_skins<Skin>();
            skin.InDegub(demonshunt);
            skin.InDegub(badintentions);
            skin.InDegub(youngblood);
        }
    }
}
