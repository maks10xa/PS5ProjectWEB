using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPS5Project.Presentation
{
    public class Constant
    {
        public const string EmptyLoginPass = "Поля \"Логин\" и \"Пароль\" должны быть заполнены";
        public const string AuthorizedError = "Ошибка авторизации!";
        public const string NoUsersInDb = "Такого пользователя не существует, проверьте введенные данные или зарегистрируйтесь!";

        public const string RegistrationError = "Ошибка регистрации!";
        public const string OK = "OK";
        public const string EmptyNameField = "Поле \"Имя\" должно быть заполнено!";
        public const string NotCorrectLogin = "Пользователь с таким логином уже зарегистрирован!";
        public const string SuccessfulRegistration = "Регистрация прошла успешна, теперь авторизуйтесь!";

        public const string InfoText = "— Вы звоните нам или оставляете заявку на сайте, предварительно выбрав тариф аренды ps 5 на сутки, на трое суток или на неделю;\n" +
                                       "\n— Мы принимаем Ваш заказ и договариваемся с Вами о дате, времени, а также играх, в которые Вы бы хотели поиграть;\n" +
                                       "\n— Если вы не определились с играми, то мы обязательно поможем вам выбрать как новые тайтлы на PlayStation 5, так и старые (PlayStation 4), чтобы Ваше время прошло с максимальным комфортом и удовольствием;\n" +
                                       "\nЗаключаем с вами договор на прокат (аренду) PlayStation 5 (для этого нужен будет Ваш паспорт) и подключаем у Вас дома игровую консоль (если Вы у нас не в первый раз — возможен самовывоз);\n" +
                                       "\n— В течение периода проката Sony PlayStation 5 мы консультируем Вас и всегда рады помочь Вам разобраться в вопросах которые могут Вас беспокоить;" +
                                       "\n— По окончанию периода аренды Playstation 5 мы приезжаем к Вам (если вы не захотите продлить период аренды) и забираем оборудование!";

        public const string GamesNullComboBox = "Пока не добавлено";

        public const string FavoriteGame = "Любимая игра: ";
        public const string AddGameToFavorite = "Игра добавлена в избранное!";
    }
}
