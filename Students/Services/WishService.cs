using System;
using System.Collections.Generic;

namespace Students.Services
{
    public class WishService : IWishService
    {
        private readonly List<string> _wishes = new()
        {
            "Нехай кожен день приносить нові знання та натхнення!",
            "Бажаю легких і цікавих занять та добрих викладачів!",
            "Нехай навчання відкриває перед тобою нові горизонти!",
            "Бажаю впевненості у власних силах та успіхів у всіх справах!",
            "Нехай друзі та команда завжди підтримують тебе на шляху до мети!",
            "Бажаю здоров’я, радості та гармонії у житті!",
            "Нехай кожна оцінка буде лише сходинкою до великих досягнень!",
            "Бажаю сміливості пробувати нове та не боятися помилок!",
            "Нехай мрії стають планами, а плани — реальністю!",
            "Бажаю завжди знаходити час для відпочинку та натхнення!"
        };

        private readonly Random _random = new();

        public string GetRandomWish()
        {
            int index = _random.Next(_wishes.Count);
            return _wishes[index];
        }
    }
}
