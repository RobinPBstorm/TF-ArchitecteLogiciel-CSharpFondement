using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Procedure_Fonction
{
    public struct CoffeeCupStruct
    {
        public uint volume;

        public CoffeeCupStruct(uint volume)
        {
            this.volume = volume;
        }
        public CoffeeCupStruct(int volume)
        {
            if (volume >= 0)
            {
                this.volume = (uint)volume;
            }
            else
            {
                this.volume = 0;
            }
        }

        // procédure
        public void Fill(uint volume)
        {
            volume *= 2;
            this.volume = volume;
        }
        // paramètre optionnel => les derniers défini
        // posséde une valeur par defaut
        public void FillWithOptional(uint volume = 5)
        {
            this.volume = volume;
        }
        public void FillRef(ref uint volume)
        {
            volume *= 2;
            this.volume = volume;
        }
        public void FillWithParams(params uint[] volumes)
        {
            foreach (uint volume in volumes)
            {
                this.volume += volume;
            }
        }


        // Fonction
        public bool isEmpty()
        {
            return volume == 0;
        }
        // surcharge = même nom mais les mêmes paramètres (type et nombre)
        // signature = nom + paramètre
        public bool TryEmpty(uint volumeToRemove, out uint finalVolume)
        {
            if (volume >= volumeToRemove)
            {
                volume -= volumeToRemove;
                finalVolume = volume;
                return true;
            }
            else
            {
                finalVolume = volume;
                return false;
            }
        }
        public bool TryEmpty(uint volumeToRemove, out uint finalVolume, out string message)
        {
            if (volume >= volumeToRemove)
            {
                volume -= volumeToRemove;
                finalVolume = volume;
                message = "C'était bien bon";
                return true;
            }
            else
            {
                finalVolume = volume;
                message = "Il n'y en avait pas assez";
                return false;
            }
        }
    }
}
