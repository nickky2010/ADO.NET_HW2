using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_HW2.Localizations
{
    public class RussianLocalization: ILocalization
    {
        public string trainingToolStripMenuItem => "Треннинг";
        public string editToolStripMenuItem => "Редактирование";
        public string settingsToolStripMenuItem => "Настройки";
        public string fromRussianToEnglishToolStripMenuItem => "С Русского на Английский";
        public string fromEnglishToRussianToolStripMenuItem => "С Английского на Русский";
        public string aboutAdvertisingToolStripMenuItem => "Заказ рекламы";
        public string exitToolStripMenuItem => "Выход";
        public string labelWord => "Слово";
        public string labelTranslation => "Перевод";
        public string buttonСonfirm => "Принять";
        public string buttonNext => "Далее";
        public string buttonShowPicture => "Показать картинку";
        public string formText => "Изучаем Английский";
        public string buttonSaveChanges => "Сохранить";
        public string buttonCancel => "Отмена";
        public string buttonAddPicture => "Добавить картинку";
    }
}
