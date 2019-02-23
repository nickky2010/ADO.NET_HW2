using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_HW2.Localizations
{
    public interface ILocalization
    {
        string trainingToolStripMenuItem { get; }
        string editToolStripMenuItem { get; }
        string settingsToolStripMenuItem { get; }
        string fromRussianToEnglishToolStripMenuItem { get; }
        string fromEnglishToRussianToolStripMenuItem { get; }
        string aboutAdvertisingToolStripMenuItem { get; }
        string exitToolStripMenuItem { get; }
        string labelWord { get; }
        string labelTranslation { get; }
        string buttonСonfirm { get; }
        string buttonNext { get; }
        string buttonShowPicture { get; }
        string formText { get; }
        string buttonSaveChanges { get; }
        string buttonCancel { get; }
        string buttonAddPicture { get; }

    }
}
