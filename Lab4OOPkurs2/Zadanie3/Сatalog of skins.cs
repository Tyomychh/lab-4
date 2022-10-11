using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Zadanie3
{
    internal class Сatalog_of_skins<T> where T : Skin
    {
        public void InDegub(T skin)
        {
            Debug.WriteLine($"\tВаш образ називається : {skin}, його цiна : {skin.Price}, його рiдкiсть : {skin.Rarity} ");
            Console.WriteLine($"\tВаш образ називається : {skin}, його цiна : {skin.Price}, його рiдкiсть : {skin.Rarity} ");
        }
    }
}
